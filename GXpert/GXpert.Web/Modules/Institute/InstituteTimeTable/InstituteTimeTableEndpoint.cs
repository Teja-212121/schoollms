using GXpert.Web.Enums;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using System.IO;
using MyRow = GXpert.Institute.InstituteTimeTableRow;

namespace GXpert.Institute.Endpoints;

[Route("Services/Institute/InstituteTimeTable/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class InstituteTimeTableEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IInstituteTimeTableSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IInstituteTimeTableSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IInstituteTimeTableDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IInstituteTimeTableRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IInstituteTimeTableListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IInstituteTimeTableListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.InstituteTimeTableColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "InstituteTimeTableList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, ExcelImportRequest request,
       [FromServices] IUploadStorage uploadStorage,
       [FromServices] IInstituteSaveHandler handler)
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

              
                Row.Date = Convert.ToDateTime(worksheet.Cells[row, 1].Value ?? "");
                Row.StartTime = Convert.ToDateTime(worksheet.Cells[row, 2].Value ?? "");
                Row.EndTime = Convert.ToDateTime(worksheet.Cells[row, 3].Value ?? "");
                Row.PeriodIndex = Convert.ToInt32(worksheet.Cells[row, 4].Value ?? null);

                Row.InstituteDivisionId = Convert.ToInt32(worksheet.Cells[row, 5].Value ?? null);
                /*if (string.IsNullOrEmpty(Row.InstituteClassDivision))
                {
                    response.ErrorList.Add("Error On Row " + row + ": class Not found");
                    continue;
                }*/
                Row.TeacherId = Convert.ToInt32(worksheet.Cells[row, 6].Value ?? null);
               /* if (string.IsNullOrEmpty(Row.TeacherPrn))
                {
                    response.ErrorList.Add("Error On Row " + row + ": Prn Not found");
                    continue;
                }
*/
                //int? EType = Convert.ToInt32(worksheet.Cells[row, 7].Value ?? null);
                //if (EType != null)
                //{

                //    if (EType == 1)
                //        Row.EType = EInstituteTimeTableType.SINGLE_RIGHT_ANSWER;
                //    else if (EType == 2)
                //        Row.EType = EInstituteTimeTableType.MULTIPLE_RIGHT_ANSWER;
                //    else if (EType == 3)
                //        Row.EType = EInstituteTimeTableType.NUMERICAL;
                //    else if (EType == 4)
                //        Row.EType = EInstituteTimeTableType.TRUE_OR_FALSE;

                //    else
                //    {
                //        response.ErrorList.Add("Error On Row " + row + ":Invalid Question Type !");
                //        continue;
                //    }
                //}
                    Row.ClassRoomNo = Convert.ToInt32(worksheet.Cells[row, 7].Value ?? null);
                

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



