using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Attendance.Pages;

[PageAuthorize(typeof(StudentClassAttendanceRow))]
public class StudentClassAttendancePage : Controller
{
    [Route("Attendance/StudentClassAttendance")]
    public ActionResult Index()
    {
        return this.GridPage("@/Attendance/StudentClassAttendance/StudentClassAttendancePage",
            StudentClassAttendanceRow.Fields.PageTitle());
    }
    [Route("Attendance/StudentClassAttendance/StudentAttendanceImportSample")]
    public FileContentResult DownloadSubjectPlanSample()
    {
        string filePath = "Uploads/StudentClassAttendanceDownloadImportSample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}