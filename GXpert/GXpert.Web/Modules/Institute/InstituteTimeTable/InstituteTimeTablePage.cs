using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Institute.Pages;

[PageAuthorize(typeof(InstituteTimeTableRow))]
public class InstituteTimeTablePage : Controller
{
    [Route("Institute/InstituteTimeTable")]
    public ActionResult Index()
    {
        return this.GridPage("@/Institute/InstituteTimeTable/InstituteTimeTablePage",
            InstituteTimeTableRow.Fields.PageTitle());
    }
    [Route("Institute/InstituteTimeTable/InstituteTimeTableDownloadSample")]
    public FileContentResult InstituteTimeTableDownloadSample()
    {
        string filePath = "Uploads/InstituteTimetableDownloadImportSample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }

}