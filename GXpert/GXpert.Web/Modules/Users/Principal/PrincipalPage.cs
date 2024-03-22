using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Users.Pages;

[PageAuthorize(typeof(PrincipalRow))]
public class PrincipalPage : Controller
{
    [Route("Users/Principal")]
    public ActionResult Index()
    {
        return this.GridPage("@/Users/Principal/PrincipalPage",
            PrincipalRow.Fields.PageTitle());
    }
}