using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.LiveSessions.Pages;

[PageAuthorize(typeof(PollRow))]
public class PollPage : Controller
{
    [Route("LiveSessions/Poll")]
    public ActionResult Index()
    {
        return this.GridPage("@/LiveSessions/Poll/PollPage",
            PollRow.Fields.PageTitle());
    }
}