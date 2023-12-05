using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Attendance.Pages;

[PageAuthorize(typeof(PollResponseRow))]
public class PollResponsePage : Controller
{
    [Route("Attendance/PollResponse")]
    public ActionResult Index()
    {
        return this.GridPage("@/Attendance/PollResponse/PollResponsePage",
            PollResponseRow.Fields.PageTitle());
    }
}