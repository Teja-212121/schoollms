using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Settings.Pages;

[PageAuthorize(typeof(SmtpRow))]
public class SmtpPage : Controller
{
    [Route("Settings/Smtp")]
    public ActionResult Index()
    {
        return this.GridPage("@/Settings/Smtp/SmtpPage",
            SmtpRow.Fields.PageTitle());
    }
}