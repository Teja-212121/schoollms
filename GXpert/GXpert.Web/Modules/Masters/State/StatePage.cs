using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(StateRow))]
public class StatePage : Controller
{
    [Route("Masters/State")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/State/StatePage",
            StateRow.Fields.PageTitle());
    }
}