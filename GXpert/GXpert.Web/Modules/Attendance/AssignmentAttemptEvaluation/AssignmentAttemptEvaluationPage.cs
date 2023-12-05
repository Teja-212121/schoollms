using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Attendance.Pages;

[PageAuthorize(typeof(AssignmentAttemptEvaluationRow))]
public class AssignmentAttemptEvaluationPage : Controller
{
    [Route("Attendance/AssignmentAttemptEvaluation")]
    public ActionResult Index()
    {
        return this.GridPage("@/Attendance/AssignmentAttemptEvaluation/AssignmentAttemptEvaluationPage",
            AssignmentAttemptEvaluationRow.Fields.PageTitle());
    }
}