using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Attendance.Pages;

[PageAuthorize(typeof(RaiseHandRecordedSessionRow))]
public class RaiseHandRecordedSessionPage : Controller
{
    [Route("Attendance/RaiseHandRecordedSession")]
    public ActionResult Index()
    {
        return this.GridPage("@/Attendance/RaiseHandRecordedSession/RaiseHandRecordedSessionPage",
            RaiseHandRecordedSessionRow.Fields.PageTitle());
    }
}