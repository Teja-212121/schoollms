using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = GXpert.Syllabus.SubjectRow;

namespace GXpert.Syllabus.Endpoints;

[Route("Services/Syllabus/Subject/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class SubjectEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ISubjectSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] ISubjectSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] ISubjectDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] ISubjectRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] ISubjectListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] ISubjectListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.SubjectColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "SubjectList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    [HttpPost]
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
      [FromServices] IUploadStorage uploadStorage,
      [FromServices] ISubjectSaveHandler handler)
    {

        if (request is null)
            throw new ArgumentNullException(nameof(request));
        if (string.IsNullOrWhiteSpace(request.FileName))
            throw new ArgumentNullException(nameof(request.FileName));

        if (uploadStorage is null)
            throw new ArgumentNullException(nameof(uploadStorage));

        UploadPathHelper.CheckFileNameSecurity(request.FileName);

        if (!request.FileName.StartsWith("temporary/", StringComparison.OrdinalIgnoreCase))
            throw new ArgumentOutOfRangeException(nameof(request.FileName));

        ExcelPackage ep = new();
        using (var fs = uploadStorage.OpenFile(request.FileName))
            ep.Load(fs);

        var p = MyRow.Fields;
        //var p = ProductsRow.Fields;

        var response = new ExcelImportResponse
        {
            ErrorList = new List<string>()
        };

        var worksheet = ep.Workbook.Worksheets[0];


        for (var row = 2; row <= worksheet.Dimension.End.Row; row++)
        {
            try
            {
                MyRow Row = new MyRow();

                Row.CourseId = Convert.ToInt32(worksheet.Cells[row, 1].Value ?? null);
                Row.ClassId = Convert.ToInt32(worksheet.Cells[row, 2].Value ?? null);

                Row.SemesterId = Convert.ToInt32(worksheet.Cells[row, 3].Value ?? null);
               
                Row.Title = Convert.ToString(worksheet.Cells[row, 4].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Title))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Title Not found");
                    continue;
                }
                Row.SortOrder = Convert.ToInt16(worksheet.Cells[row, 5].Value ?? null);

                Row.Weightage = (float?)Convert.ToDouble(worksheet.Cells[row, 6].Value ?? null);
                
                Row.Thumbnail = Convert.ToString(worksheet.Cells[row, 7].Value ?? "").Trim();
                
                Row.Description = Convert.ToString(worksheet.Cells[row, 8].Value ?? "").Trim();
                if (string.IsNullOrEmpty(Row.Description))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Description Not found");
                    continue;
                }
               
                    Row.IsActive = true;
                    Row.InsertDate = DateTime.UtcNow;
                    Row.InsertUserId = Convert.ToInt32(User.GetIdentifier());
                    uow.Connection.Insert(Row);
                    response.Inserted = response.Inserted + 1;
                

            }
            catch (Exception)
            {
                //response.ErrorList.Add("Exception on Row " + row + ": " + ex.Message);
                throw;
            }
        }
        return response;
    }
}