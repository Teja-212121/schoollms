using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Users.Pages;

[PageAuthorize(typeof(HodRow))]
public class HodPage : Controller
{
    [Route("Users/Hod")]
    public ActionResult Index()
    {
        return this.GridPage("@/Users/Hod/HodPage",
            HodRow.Fields.PageTitle());
    }
}