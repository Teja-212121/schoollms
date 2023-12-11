using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Activation.Pages;

[PageAuthorize(typeof(PreDefinedKeyRow))]
public class PreDefinedKeyPage : Controller
{
    [Route("Activation/PreDefinedKey")]
    public ActionResult Index()
    {
        return this.GridPage("@/Activation/PreDefinedKey/PreDefinedKeyPage",
            PreDefinedKeyRow.Fields.PageTitle());
    }
}