using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Exams.Pages;

[PageAuthorize(typeof(AssignmentEvaluationRow))]
public class AssignmentEvaluationPage : Controller
{
    [Route("Exams/AssignmentEvaluation")]
    public ActionResult Index()
    {
        return this.GridPage("@/Exams/AssignmentEvaluation/AssignmentEvaluationPage",
            AssignmentEvaluationRow.Fields.PageTitle());
    }
}