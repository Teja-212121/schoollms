using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(StateRow))]
public class StatePage : Controller
{
    [Route("Masters/State")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/State/StatePage",
            StateRow.Fields.PageTitle());
    }

    [Route("Masters/State/StateSample")]
    public FileContentResult DownloadImportedQuestionsSample()
    {
        string filePath = "Uploads/StateSample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}