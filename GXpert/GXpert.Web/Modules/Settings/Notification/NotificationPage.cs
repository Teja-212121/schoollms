using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Settings.Pages;

[PageAuthorize(typeof(NotificationRow))]
public class NotificationPage : Controller
{
    [Route("Settings/Notification")]
    public ActionResult Index()
    {
        return this.GridPage("@/Settings/Notification/NotificationPage",
            NotificationRow.Fields.PageTitle());
    }
}