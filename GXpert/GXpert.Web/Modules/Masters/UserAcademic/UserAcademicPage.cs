using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(UserAcademicRow))]
public class UserAcademicPage : Controller
{
    [Route("Masters/UserAcademic")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/UserAcademic/UserAcademicPage",
            UserAcademicRow.Fields.PageTitle());
    }
}