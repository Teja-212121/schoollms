using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Syllabus.Pages;

[PageAuthorize(typeof(TopicRow))]
public class TopicPage : Controller
{
    [Route("Syllabus/Topic")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Topic/TopicPage",
            TopicRow.Fields.PageTitle());
    }
    [Route("Syllabus/TopicDownloadImportSample")]
    public FileContentResult DownloadSubjectPlanSample()
    {
        string filePath = "Uploads/TopicDownloadImportSample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}