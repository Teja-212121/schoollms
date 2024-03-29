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
using MyRow = GXpert.Masters.AcademicPerformanceRow;

namespace GXpert.Masters.Endpoints;

[Route("Services/Masters/AcademicPerformance/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class AcademicPerformanceEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IAcademicPerformanceSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IAcademicPerformanceSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IAcademicPerformanceDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IAcademicPerformanceRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IAcademicPerformanceListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IAcademicPerformanceListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.AcademicPerformanceColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "AcademicPerformanceList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, AcademicperformanceExcelImportRequest request,
       [FromServices] IUploadStorage uploadStorage,
       [FromServices] IAcademicPerformanceSaveHandler handler)
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
                int? studentId = Convert.ToInt32(worksheet.Cells[row, 1].Value ?? null);
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
                Row.CourseId = Convert.ToInt32(worksheet.Cells[row, 2].Value ?? null);
                Row.ClassId = Convert.ToInt32(worksheet.Cells[row, 3].Value ?? null);
                Row.SemesterId = Convert.ToInt32(worksheet.Cells[row, 4].Value ?? null);
                Row.MarksObtained = (float?)Convert.ToDouble(worksheet.Cells[row, 5].Value ?? null);

                Row.OutOfMarks = (float?)Convert.ToDouble(worksheet.Cells[row, 6].Value ?? null);


               
                string remark = Convert.ToString(worksheet.Cells[row, 7].Value);
                if (string.IsNullOrEmpty(remark))
                {
                    response.ErrorList.Add("Error On Row " + row + ": remark Not found");
                    continue;
                }
                Row.Remarks = remark;
                Row.AcademicYearId = Convert.ToInt32(worksheet.Cells[row, 8].Value ?? null);





                var academicPerformance = new AcademicPerformanceRow
                {
                    StudentId = Row.StudentId,
                    CourseId = Row.CourseId,
                    ClassId = Row.ClassId,
                    SemesterId = Row.SemesterId,
                    MarksObtained = Row.MarksObtained,
                    OutOfMarks = Row.OutOfMarks,
                    Remarks=Row.Remarks,
                    AcademicYearId=Row.AcademicYearId,
                    InsertDate = DateTime.Now,
                    InsertUserId = Convert.ToInt32(User.GetIdentifier())
                };
                uow.Connection.Insert<AcademicPerformanceRow>(academicPerformance);


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

    public class AcademicperformanceExcelImportRequest : ServiceRequest
    {
        public string FileName { get; set; }

    }
}