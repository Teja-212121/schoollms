using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Syllabus.Pages;

[PageAuthorize(typeof(SemesterRow))]
public class SemesterPage : Controller
{
    [Route("Syllabus/Semester")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Semester/SemesterPage",
            SemesterRow.Fields.PageTitle());
    }
}