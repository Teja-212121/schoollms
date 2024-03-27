using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(TalukaRow))]
public class TalukaPage : Controller
{
    [Route("Masters/Taluka")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/Taluka/TalukaPage",
            TalukaRow.Fields.PageTitle());
    }
    [Route("Masters/Taluka/TalukaSample")]
    public FileContentResult DownloadImportedQuestionsSample()
    {
        string filePath = "Uploads/TalukaSample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}