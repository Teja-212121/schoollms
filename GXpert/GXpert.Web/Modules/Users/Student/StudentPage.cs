using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Users.Pages;

[PageAuthorize(typeof(StudentRow))]
public class StudentPage : Controller
{
    [Route("Users/Student")]
    public ActionResult Index()
    {
        return this.GridPage("@/Users/Student/StudentPage",
            StudentRow.Fields.PageTitle());
    }
    [Route("Users/Student/StudentSample")]
    public FileContentResult DownloadImportedQuestionsSample()
    {
        string filePath = "Uploads/StudentSample.xlsx";
        byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
        return new FileContentResult(fileBytes, "application/vnd.ms-excel");
    }
}