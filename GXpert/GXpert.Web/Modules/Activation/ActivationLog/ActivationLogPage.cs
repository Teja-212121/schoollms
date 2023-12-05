using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Activation.Pages;

[PageAuthorize(typeof(ActivationLogRow))]
public class ActivationLogPage : Controller
{
    [Route("Activation/ActivationLog")]
    public ActionResult Index()
    {
        return this.GridPage("@/Activation/ActivationLog/ActivationLogPage",
            ActivationLogRow.Fields.PageTitle());
    }
}