using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentCourseRow))]
public class ContentCoursePage : Controller
{
    [Route("Content/ContentCourse")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentCourse/ContentCoursePage",
            ContentCourseRow.Fields.PageTitle());
    }
}