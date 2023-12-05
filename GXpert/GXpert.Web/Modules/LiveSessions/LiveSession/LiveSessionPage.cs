using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.LiveSessions.Pages;

[PageAuthorize(typeof(LiveSessionRow))]
public class LiveSessionPage : Controller
{
    [Route("LiveSessions/LiveSession")]
    public ActionResult Index()
    {
        return this.GridPage("@/LiveSessions/LiveSession/LiveSessionPage",
            LiveSessionRow.Fields.PageTitle());
    }
}