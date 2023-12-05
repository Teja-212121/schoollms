using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Schools.Pages;

[PageAuthorize(typeof(SchoolRow))]
public class SchoolPage : Controller
{
    [Route("Schools/School")]
    public ActionResult Index()
    {
        return this.GridPage("@/Schools/School/SchoolPage",
            SchoolRow.Fields.PageTitle());
    }
}