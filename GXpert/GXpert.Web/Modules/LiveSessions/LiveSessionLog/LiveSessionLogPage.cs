using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.LiveSessions.Pages;

[PageAuthorize(typeof(LiveSessionLogRow))]
public class LiveSessionLogPage : Controller
{
    [Route("LiveSessions/LiveSessionLog")]
    public ActionResult Index()
    {
        return this.GridPage("@/LiveSessions/LiveSessionLog/LiveSessionLogPage",
            LiveSessionLogRow.Fields.PageTitle());
    }
}