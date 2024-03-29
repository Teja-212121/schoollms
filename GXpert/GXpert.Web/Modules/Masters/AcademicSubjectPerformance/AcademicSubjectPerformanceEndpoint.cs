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
using MyRow = GXpert.Masters.AcademicSubjectPerformanceRow;

namespace GXpert.Masters.Endpoints;

[Route("Services/Masters/AcademicSubjectPerformance/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class AcademicSubjectPerformanceEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IAcademicSubjectPerformanceSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IAcademicSubjectPerformanceSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IAcademicSubjectPerformanceDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IAcademicSubjectPerformanceRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IAcademicSubjectPerformanceListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IAcademicSubjectPerformanceListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.AcademicSubjectPerformanceColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "AcademicSubjectPerformanceList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, AcademicSubjectExcelImportRequest request,
        [FromServices] IUploadStorage uploadStorage,
        [FromServices] IAcademicSubjectPerformanceSaveHandler handler)
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
                Row.SubjectId = Convert.ToInt32(worksheet.Cells[row, 5].Value ?? null);
                int? eTypeOfExam = Convert.ToInt32(worksheet.Cells[row, 6].Value ?? null);
                if (eTypeOfExam != null)
                {

                    if (eTypeOfExam == 1)
                        Row.ETypeOfExam = Web.Enums.ETypeOfExam.THEORY;
                    else if (eTypeOfExam == 2)
                        Row.ETypeOfExam = Web.Enums.ETypeOfExam.PRACTICAL;
                    else if (eTypeOfExam == 3)
                        Row.ETypeOfExam = Web.Enums.ETypeOfExam.ORAL;


                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid ETypeOfExam  !");
                        continue;
                    }
                }

                Row.MarksObtained = (float?)Convert.ToDouble(worksheet.Cells[row, 7].Value ?? null);

                Row.OutOfMarks = (float?)Convert.ToDouble(worksheet.Cells[row, 8].Value ?? null);



                string remark = Convert.ToString(worksheet.Cells[row, 9].Value);
                if (string.IsNullOrEmpty(remark))
                {
                    response.ErrorList.Add("Error On Row " + row + ": remark Not found");
                    continue;
                }
                Row.Remarks = remark;
                Row.AcademicYearId = Convert.ToInt32(worksheet.Cells[row, 10].Value ?? null);





                var academicSubjectPerformance = new AcademicSubjectPerformanceRow
                {
                    StudentId = Row.StudentId,
                    CourseId = Row.CourseId,
                    ClassId = Row.ClassId,
                    SemesterId = Row.SemesterId,
                    SubjectId=Row.SubjectId,
                    ETypeOfExam=Row.ETypeOfExam,
                    MarksObtained = Row.MarksObtained,
                    OutOfMarks = Row.OutOfMarks,
                    Remarks = Row.Remarks,
                    AcademicYearId = Row.AcademicYearId,
                    InsertDate = DateTime.Now,
                    InsertUserId = Convert.ToInt32(User.GetIdentifier())
                };
                uow.Connection.Insert<AcademicSubjectPerformanceRow>(academicSubjectPerformance);


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

    public class AcademicSubjectExcelImportRequest : ServiceRequest
    {
        public string FileName { get; set; }

    }
}