using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Institute.Pages;

[PageAuthorize(typeof(InstituteTeacherRow))]
public class InstituteTeacherPage : Controller
{
    [Route("Institute/InstituteTeacher")]
    public ActionResult Index()
    {
        return this.GridPage("@/Institute/InstituteTeacher/InstituteTeacherPage",
            InstituteTeacherRow.Fields.PageTitle());
    }
}