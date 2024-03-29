using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(PreAcademicScoreRow))]
public class PreAcademicScorePage : Controller
{
    [Route("Masters/PreAcademicScore")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/PreAcademicScore/PreAcademicScorePage",
            PreAcademicScoreRow.Fields.PageTitle());
    }
    [Route("Masters/PreAcademicScore/PreacademicScoreSample")]
    public FileContentResult DownloadImportedQuestionsSample()
    {
        string filePath = "Uploads/PreacademicScoresample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}