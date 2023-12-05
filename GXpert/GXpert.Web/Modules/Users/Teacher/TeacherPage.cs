using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Users.Pages;

[PageAuthorize(typeof(TeacherRow))]
public class TeacherPage : Controller
{
    [Route("Users/Teacher")]
    public ActionResult Index()
    {
        return this.GridPage("@/Users/Teacher/TeacherPage",
            TeacherRow.Fields.PageTitle());
    }
}