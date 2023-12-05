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
}