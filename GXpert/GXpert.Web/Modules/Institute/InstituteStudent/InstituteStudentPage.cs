using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Institute.Pages;

[PageAuthorize(typeof(InstituteStudentRow))]
public class InstituteStudentPage : Controller
{
    [Route("Institute/InstituteStudent")]
    public ActionResult Index()
    {
        return this.GridPage("@/Institute/InstituteStudent/InstituteStudentPage",
            InstituteStudentRow.Fields.PageTitle());
    }
}