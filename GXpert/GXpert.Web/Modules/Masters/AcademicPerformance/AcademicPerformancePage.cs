using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(AcademicPerformanceRow))]
public class AcademicPerformancePage : Controller
{
    [Route("Masters/AcademicPerformance")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/AcademicPerformance/AcademicPerformancePage",
            AcademicPerformanceRow.Fields.PageTitle());
    }
    [Route("Masters/AcademicPerformance/AcademicPerformanceSample")]
    public FileContentResult DownloadImportedQuestionsSample()
    {
        string filePath = "Uploads/AcademicPerformanceSample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}