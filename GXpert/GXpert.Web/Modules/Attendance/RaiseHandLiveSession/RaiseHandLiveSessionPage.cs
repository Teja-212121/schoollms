using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Attendance.Pages;

[PageAuthorize(typeof(RaiseHandLiveSessionRow))]
public class RaiseHandLiveSessionPage : Controller
{
    [Route("Attendance/RaiseHandLiveSession")]
    public ActionResult Index()
    {
        return this.GridPage("@/Attendance/RaiseHandLiveSession/RaiseHandLiveSessionPage",
            RaiseHandLiveSessionRow.Fields.PageTitle());
    }
}