using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Settings.Pages;

[PageAuthorize(typeof(SmsRow))]
public class SmsPage : Controller
{
    [Route("Settings/Sms")]
    public ActionResult Index()
    {
        return this.GridPage("@/Settings/Sms/SmsPage",
            SmsRow.Fields.PageTitle());
    }
}