using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Exams.Pages;

[PageAuthorize(typeof(AssignmentRow))]
public class AssignmentPage : Controller
{
    [Route("Exams/Assignment")]
    public ActionResult Index()
    {
        return this.GridPage("@/Exams/Assignment/AssignmentPage",
            AssignmentRow.Fields.PageTitle());
    }
}