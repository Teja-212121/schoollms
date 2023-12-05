using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Activation.Pages;

[PageAuthorize(typeof(ActivationRow))]
public class ActivationPage : Controller
{
    [Route("Activation/Activation")]
    public ActionResult Index()
    {
        return this.GridPage("@/Activation/Activation/ActivationPage",
            ActivationRow.Fields.PageTitle());
    }
}