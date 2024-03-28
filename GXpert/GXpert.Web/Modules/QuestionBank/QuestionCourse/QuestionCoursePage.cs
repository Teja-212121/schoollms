using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.QuestionBank.Pages;

[PageAuthorize(typeof(QuestionCourseRow))]
public class QuestionCoursePage : Controller
{
    [Route("QuestionBank/QuestionCourse")]
    public ActionResult Index()
    {
        return this.GridPage("@/QuestionBank/QuestionCourse/QuestionCoursePage",
            QuestionCourseRow.Fields.PageTitle());
    }
}