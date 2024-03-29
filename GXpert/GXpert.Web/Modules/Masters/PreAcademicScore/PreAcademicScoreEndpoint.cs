using GXpert.Users;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = GXpert.Masters.PreAcademicScoreRow;

namespace GXpert.Masters.Endpoints;

[Route("Services/Masters/PreAcademicScore/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class PreAcademicScoreEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IPreAcademicScoreSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IPreAcademicScoreSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IPreAcademicScoreDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IPreAcademicScoreRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IPreAcademicScoreListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IPreAcademicScoreListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.PreAcademicScoreColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "PreAcademicScoreList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, PreAcademicScoreExcelImportRequest request,
        [FromServices] IUploadStorage uploadStorage,
        [FromServices] IPreAcademicScoreSaveHandler handler)
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

                
                int? preacademicId = Convert.ToInt32(worksheet.Cells[row, 1].Value ?? null);
                if (preacademicId == 0)
                    preacademicId = null;
                if (preacademicId != null)
                {
                    var PreAcademic = uow.Connection.TryFirst<PreAcademicRow>(PreAcademicRow.Fields.Id == preacademicId.Value);
                    if (PreAcademic != null)
                    {
                        Row.PreAcadamicsId = PreAcademic.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid PreAcademic !");
                        continue;
                    }
                }

                string dateString = Convert.ToString(worksheet.Cells[row, 2].Value);
                if (!string.IsNullOrEmpty(dateString))
                {
                    if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime paasesoutdate))
                    {
                        Row.PassedOutDate = paasesoutdate;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid date format for paasesoutdate.");
                        continue;
                    }
                }
                else
                {
                    response.ErrorList.Add("Error On Row " + row + ": Date of Birth not found.");
                    continue;
                }

                Row.MarksObtained = (float?)Convert.ToDouble(worksheet.Cells[row, 3].Value ?? null);

                Row.OutOfMarks = (float?)Convert.ToDouble(worksheet.Cells[row, 4].Value ?? null);


                int? studentId = Convert.ToInt32(worksheet.Cells[row, 5].Value ?? null);
                if (studentId == 0)
                    studentId = null;
                if (studentId != null)
                {
                    var students = uow.Connection.TryFirst<StudentRow>(StudentRow.Fields.Id == studentId.Value);
                    if (students != null)
                    {
                        Row.StudentId = students.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid student !");
                        continue;
                    }
                }

                string remark = Convert.ToString(worksheet.Cells[row, 6].Value);
                if (string.IsNullOrEmpty(remark))
                {
                    response.ErrorList.Add("Error On Row " + row + ": remark Not found");
                    continue;
                }
                Row.Remarks = remark;
               
                var preacademicScore = new PreAcademicScoreRow
                {
                   
                   PreAcadamicsId = Row.PreAcadamicsId,
                    PassedOutDate = Row.PassedOutDate,
                    MarksObtained = Row.MarksObtained,
                    OutOfMarks = Row.OutOfMarks,
                    StudentId = Row.StudentId,
                    Remarks = Row.Remarks,
                    InsertDate = DateTime.Now,
                    InsertUserId = Convert.ToInt32(User.GetIdentifier())
                };
                uow.Connection.Insert<PreAcademicScoreRow>(preacademicScore);


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

    public class PreAcademicScoreExcelImportRequest : ServiceRequest
    {
        public string FileName { get; set; }

    }

}