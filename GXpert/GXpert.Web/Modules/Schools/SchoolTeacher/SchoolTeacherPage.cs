using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Schools.Pages;

[PageAuthorize(typeof(SchoolTeacherRow))]
public class SchoolTeacherPage : Controller
{
    [Route("Schools/SchoolTeacher")]
    public ActionResult Index()
    {
        return this.GridPage("@/Schools/SchoolTeacher/SchoolTeacherPage",
            SchoolTeacherRow.Fields.PageTitle());
    }
}