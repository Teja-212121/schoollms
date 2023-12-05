using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Attendance.Pages;

[PageAuthorize(typeof(AssignmentAttemptRow))]
public class AssignmentAttemptPage : Controller
{
    [Route("Attendance/AssignmentAttempt")]
    public ActionResult Index()
    {
        return this.GridPage("@/Attendance/AssignmentAttempt/AssignmentAttemptPage",
            AssignmentAttemptRow.Fields.PageTitle());
    }
}