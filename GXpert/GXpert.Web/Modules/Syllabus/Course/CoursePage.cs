using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Syllabus.Pages;

[PageAuthorize(typeof(CourseRow))]
public class CoursePage : Controller
{
    [Route("Syllabus/Course")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Course/CoursePage",
            CourseRow.Fields.PageTitle());
    }
}