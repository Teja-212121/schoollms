using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(AcademicSubjectPerformanceRow))]
public class AcademicSubjectPerformancePage : Controller
{
    [Route("Masters/AcademicSubjectPerformance")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/AcademicSubjectPerformance/AcademicSubjectPerformancePage",
            AcademicSubjectPerformanceRow.Fields.PageTitle());
    }
    [Route("Masters/AcademicSubjectPerformance/AcademicSubjectSample")]
    public FileContentResult DownloadImportedQuestionsSample()
    {
        string filePath = "Uploads/AcademicSubjectPerformance.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}