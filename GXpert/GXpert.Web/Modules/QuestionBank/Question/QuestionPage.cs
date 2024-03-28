using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.QuestionBank.Pages;

[PageAuthorize(typeof(QuestionRow))]
public class QuestionPage : Controller
{
    [Route("QuestionBank/Question")]
    public ActionResult Index()
    {
        return this.GridPage("@/QuestionBank/Question/QuestionPage",
            QuestionRow.Fields.PageTitle());
    }
    [Route("QuestionBank/Question/QuestionDownloadSample")]
    public FileContentResult InstituteTimeTableDownloadSample()
    {
        string filePath = "Uploads/QuestionsDownloadImportSample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}