using GXpert.Web.Enums;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = GXpert.Attendance.StudentClassAttendanceRow;

namespace GXpert.Attendance.Endpoints;

[Route("Services/Attendance/StudentClassAttendance/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class StudentClassAttendanceEndpoint : ServiceEndpoint
{
    private const bool V = true;

    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IStudentClassAttendanceSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IStudentClassAttendanceSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IStudentClassAttendanceDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IStudentClassAttendanceRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IStudentClassAttendanceListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IStudentClassAttendanceListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.StudentClassAttendanceColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "StudentClassAttendanceList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, StateExcelImportRequest request,
           [FromServices] IUploadStorage uploadStorage,
           [FromServices] IStudentClassAttendanceSaveHandler handler)
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
                Row.InstituteTimeTableId = Convert.ToInt32(worksheet.Cells[row, 1].Value ?? null);
                Row.StudentId = Convert.ToInt32(worksheet.Cells[row, 2].Value ?? null);

                int? eAttendanceStatus = Convert.ToInt32(worksheet.Cells[row, 3].Value ?? null);
                if (eAttendanceStatus != null)
                {

                    // if (eQuestionType > 0 && eQuestionType < 3)

                    if (eAttendanceStatus == 1)
                        Row.AttendanceStatus = Web.Enums.EAttendanceStatus.Present;
                    else if (eAttendanceStatus == 2)
                        Row.AttendanceStatus = Web.Enums.EAttendanceStatus.Absent;

                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid Question Type !");
                        continue;
                    }

                }

                Row.IsActive =1;
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

    public class StateExcelImportRequest : ServiceRequest
    {
        public string FileName { get; set; }

    }
}
