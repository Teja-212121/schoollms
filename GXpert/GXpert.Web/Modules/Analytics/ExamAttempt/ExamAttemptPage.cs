using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Analytics.Pages;

[PageAuthorize(typeof(ExamAttemptRow))]
public class ExamAttemptPage : Controller
{
    [Route("Analytics/ExamAttempt")]
    public ActionResult Index()
    {
        return this.GridPage("@/Analytics/ExamAttempt/ExamAttemptPage",
            ExamAttemptRow.Fields.PageTitle());
    }
}