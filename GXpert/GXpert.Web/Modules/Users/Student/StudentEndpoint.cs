using GXpert.Administration;
using GXpert.Institute;
using GXpert.Masters;
using GXpert.Syllabus;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using Serenity.Data;
using Serenity.Reporting;
using Serenity.Services;
using Serenity.Web;
using System;
using System.Data;
using System.Globalization;
using MyRow = GXpert.Users.StudentRow;

namespace GXpert.Users.Endpoints;

[Route("Services/Users/Student/[action]")]
[ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
public class StudentEndpoint : ServiceEndpoint
{
    [HttpPost, AuthorizeCreate(typeof(MyRow))]
    public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IStudentSaveHandler handler)
    {
        return handler.Create(uow, request);
    }

    [HttpPost, AuthorizeUpdate(typeof(MyRow))]
    public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request,
        [FromServices] IStudentSaveHandler handler)
    {
        return handler.Update(uow, request);
    }
 
    [HttpPost, AuthorizeDelete(typeof(MyRow))]
    public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request,
        [FromServices] IStudentDeleteHandler handler)
    {
        return handler.Delete(uow, request);
    }

    [HttpPost]
    public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request,
        [FromServices] IStudentRetrieveHandler handler)
    {
        return handler.Retrieve(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public ListResponse<MyRow> List(IDbConnection connection, ListRequest request,
        [FromServices] IStudentListHandler handler)
    {
        return handler.List(connection, request);
    }

    [HttpPost, AuthorizeList(typeof(MyRow))]
    public FileContentResult ListExcel(IDbConnection connection, ListRequest request,
        [FromServices] IStudentListHandler handler,
        [FromServices] IExcelExporter exporter)
    {
        var data = List(connection, request, handler).Entities;
        var bytes = exporter.Export(data, typeof(Columns.StudentColumns), request.ExportColumns);
        return ExcelContentResult.Create(bytes, "StudentList_" +
            DateTime.Now.ToString("yyyyMMdd_HHmmss", CultureInfo.InvariantCulture) + ".xlsx");
    }
    public ExcelImportResponse ExcelImport(IUnitOfWork uow, StudentExcelImportRequest request,
          [FromServices] IUploadStorage uploadStorage,
          [FromServices] IStudentSaveHandler handler)
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

                string prn = Convert.ToString(worksheet.Cells[row, 1].Value);
                if (string.IsNullOrEmpty(prn))
                {
                    response.ErrorList.Add("Error On Row " + row + ": PRN Not found");
                    continue;
                }
                Row.Prn = prn;
                string name = Convert.ToString(worksheet.Cells[row, 2].Value);
                if (string.IsNullOrEmpty(name))
                {
                    response.ErrorList.Add("Error On Row " + row + ": name Not found");
                    continue;
                }
                Row.Name = name;
                string email = Convert.ToString(worksheet.Cells[row, 3].Value);
                if (string.IsNullOrEmpty(prn))
                {
                    response.ErrorList.Add("Error On Row " + row + ": email Not found");
                    continue;
                }
                Row.Email = email;
                string mobile = Convert.ToString(worksheet.Cells[row, 4].Value);
                if (string.IsNullOrEmpty(prn))
                {
                    response.ErrorList.Add("Error On Row " + row + ": mobile Not found");
                    continue;
                }
                Row.Mobile = mobile;
                int? userId = Convert.ToInt32(worksheet.Cells[row, 5].Value ?? null);
                if (userId == 0)
                    userId = null;
                if (userId != null)
                {
                    var User = uow.Connection.TryFirst<UserRow>(UserRow.Fields.UserId == userId.Value);
                    if (User != null)
                    {
                        Row.UserId = User.UserId;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid userId !");
                        continue;
                    }
                }
                int? instituteId = Convert.ToInt32(worksheet.Cells[row, 6].Value ?? null);
                if (instituteId == 0)
                    instituteId = null;
                if (instituteId != null)
                {
                    var Institute = uow.Connection.TryFirst<InstituteRow>(InstituteRow.Fields.Id == instituteId.Value);
                    if (Institute != null)
                    {
                        Row.InstituteId = Institute.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid InstituteId !");
                        continue;
                    }
                }
                int? departmentId = Convert.ToInt32(worksheet.Cells[row, 7].Value ?? null);
                if (departmentId == 0)
                    departmentId = null;
                if (departmentId != null)
                {
                    var Department = uow.Connection.TryFirst<DepartmentRow>(DepartmentRow.Fields.Id == departmentId.Value);
                    if (Department != null)
                    {
                        Row.DepartmentId = Department.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid departmentId !");
                        continue;
                    }
                }

                int? branchId = Convert.ToInt32(worksheet.Cells[row, 8].Value ?? null);
                if (branchId == 0)
                    branchId = null;
                if (branchId != null)
                {
                    var Branch = uow.Connection.TryFirst<BranchRow>(BranchRow.Fields.Id == branchId.Value);
                    if (Branch != null)
                    {
                        Row.BranchId = Branch.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid BranchId !");
                        continue;
                    }
                }
                int? diviisionId = Convert.ToInt32(worksheet.Cells[row, 9].Value ?? null);
                if (diviisionId == 0)
                    diviisionId = null;
                if (diviisionId != null)
                {
                    var Division = uow.Connection.TryFirst<InstituteDivisionRow>(InstituteDivisionRow.Fields.Id == diviisionId.Value);
                    if (Division != null)
                    {
                        Row.DivisionId = Division.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid Division Id !");
                        continue;
                    }
                }
                int? courseId = Convert.ToInt32(worksheet.Cells[row, 10].Value ?? null);
                if (courseId == 0)
                    courseId = null;
                if (courseId != null)
                {
                    var Course = uow.Connection.TryFirst<CourseRow>(CourseRow.Fields.Id == courseId.Value);
                    if (Course != null)
                    {
                        Row.CourseId = Course.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid Course !");
                        continue;
                    }
                }
                int? classId = Convert.ToInt32(worksheet.Cells[row, 11].Value ?? null);
                if (classId == 0)
                    classId = null;
                if (classId != null)
                {
                    var Class = uow.Connection.TryFirst<ClassRow>(ClassRow.Fields.Id == classId.Value);
                    if (Class != null)
                    {
                        Row.ClassId = Class.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid class Id !");
                        continue;
                    }
                }
                int? semesterId = Convert.ToInt32(worksheet.Cells[row, 12].Value ?? null);
                if (semesterId == 0)
                    semesterId = null;
                if (semesterId != null)
                {
                    var Semester = uow.Connection.TryFirst<SemesterRow>(SemesterRow.Fields.Id == semesterId.Value);
                    if (Semester != null)
                    {
                        Row.SemesterId = Semester.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid Semester Id !");
                        continue;
                    }
                }
                int? currentAcademicyearId = Convert.ToInt32(worksheet.Cells[row, 13].Value ?? null);
                if (currentAcademicyearId == 0)
                    currentAcademicyearId = null;
                if (currentAcademicyearId != null)
                {
                    var CurrentAcademicyear = uow.Connection.TryFirst<AcademicYearRow>(AcademicYearRow.Fields.Id == currentAcademicyearId.Value);
                    if (CurrentAcademicyear != null)
                    {
                        Row.CurrentAcademicYearId = CurrentAcademicyear.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid current academic year Id !");
                        continue;
                    }
                }
                int? eGender = Convert.ToInt32(worksheet.Cells[row, 14].Value ?? null);
                if (eGender != null)
                {

                    if (eGender == 1)
                        Row.Gender = Web.Enums.EGender.Female;
                    else if (eGender == 2)
                        Row.Gender = Web.Enums.EGender.Male;
                    else if (eGender == 3)
                        Row.Gender = Web.Enums.EGender.Transgender;
                    

                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid gender  !");
                        continue;
                    }
                }
                
              
                string addressline1 = Convert.ToString(worksheet.Cells[row, 15].Value);
                if (string.IsNullOrEmpty(addressline1))
                {
                    response.ErrorList.Add("Error On Row " + row + ": addressline1 Not found");
                    continue;
                }
                Row.AddressLine1 = addressline1;
                string addressline2 = Convert.ToString(worksheet.Cells[row, 16].Value);
                if (string.IsNullOrEmpty(addressline2))
                {
                    response.ErrorList.Add("Error On Row " + row + ": addressline2 Not found");
                    continue;
                }
                Row.AddressLine2 = addressline2;
                int? stateId = Convert.ToInt32(worksheet.Cells[row, 17].Value ?? null);
                if (stateId == 0)
                    stateId = null;
                if (stateId != null)
                {
                    var State = uow.Connection.TryFirst<StateRow>(StateRow.Fields.Id == stateId.Value);
                    if (State != null)
                    {
                        Row.StateId = State.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid StateId !");
                        continue;
                    }
                }
                int? districtId = Convert.ToInt32(worksheet.Cells[row, 18].Value ?? null);
                if (districtId == 0)
                    districtId = null;
                if (districtId != null)
                {
                    var District = uow.Connection.TryFirst<DistrictRow>(DistrictRow.Fields.Id == districtId.Value);
                    if (District != null)
                    {
                        Row.DistrictId = District.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid District !");
                        continue;
                    }
                }
                int? talukaId = Convert.ToInt32(worksheet.Cells[row, 19].Value ?? null);
                if (talukaId == 0)
                    talukaId = null;
                if (talukaId != null)
                {
                    var Taluka = uow.Connection.TryFirst<TalukaRow>(TalukaRow.Fields.Id == districtId.Value);
                    if (Taluka != null)
                    {
                        Row.TalukaId = Taluka.Id;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ":Invalid Taluka !");
                        continue;
                    }
                }

                string dateString = Convert.ToString(worksheet.Cells[row, 20].Value);
                if (!string.IsNullOrEmpty(dateString))
                {
                    if (DateTime.TryParseExact(dateString, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dob))
                    {
                        Row.Dob = dob;
                    }
                    else
                    {
                        response.ErrorList.Add("Error On Row " + row + ": Invalid date format for Date of Birth.");
                        continue;
                    }
                }
                else
                {
                    response.ErrorList.Add("Error On Row " + row + ": Date of Birth not found.");
                    continue;
                }



                var student = new StudentRow
                {
                    Prn = Row.Prn,
                    Name=Row.Name,
                    Email=Row.Email,
                    Mobile=Row.Mobile,
                    UserId = Row.UserId,
                    InstituteId = Row.InstituteId,
                    DepartmentId = Row.DepartmentId,
                    BranchId = Row.BranchId,
                    SemesterId = Row.SemesterId,
                    CourseId = Row.CourseId,
                    ClassId = Row.ClassId,
                    DivisionId = Row.DivisionId,
                    CurrentAcademicYearId = Row.CurrentAcademicYearId,
                    Gender = Row.Gender,
                    AddressLine1 = Row.AddressLine1,
                    AddressLine2 = Row.AddressLine2,
                    Dob = Row.Dob,
                    StateId = Row.StateId,
                    DistrictId = Row.DistrictId,
                    InsertDate = DateTime.Now,
                    InsertUserId = Convert.ToInt32(User.GetIdentifier())
                };
                uow.Connection.Insert<StudentRow>(student);


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

    public class StudentExcelImportRequest : ServiceRequest
    {
        public string FileName { get; set; }

    }
}