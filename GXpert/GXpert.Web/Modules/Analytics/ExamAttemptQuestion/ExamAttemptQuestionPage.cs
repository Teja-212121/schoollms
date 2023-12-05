using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Analytics.Pages;

[PageAuthorize(typeof(ExamAttemptQuestionRow))]
public class ExamAttemptQuestionPage : Controller
{
    [Route("Analytics/ExamAttemptQuestion")]
    public ActionResult Index()
    {
        return this.GridPage("@/Analytics/ExamAttemptQuestion/ExamAttemptQuestionPage",
            ExamAttemptQuestionRow.Fields.PageTitle());
    }
}