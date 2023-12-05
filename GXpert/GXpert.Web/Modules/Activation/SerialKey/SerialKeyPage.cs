using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Activation.Pages;

[PageAuthorize(typeof(SerialKeyRow))]
public class SerialKeyPage : Controller
{
    [Route("Activation/SerialKey")]
    public ActionResult Index()
    {
        return this.GridPage("@/Activation/SerialKey/SerialKeyPage",
            SerialKeyRow.Fields.PageTitle());
    }
}