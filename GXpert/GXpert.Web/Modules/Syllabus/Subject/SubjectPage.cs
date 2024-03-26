using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Syllabus.Pages;

[PageAuthorize(typeof(SubjectRow))]
public class SubjectPage : Controller
{
    [Route("Syllabus/Subject")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Subject/SubjectPage",
            SubjectRow.Fields.PageTitle());
    }

    [Route("Syllabus/SubjectDownloadImportSample")]
    public FileContentResult DownloadSubjectPlanSample()
    {
        string filePath = "Uploads/SubjectDownloadImportSample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}