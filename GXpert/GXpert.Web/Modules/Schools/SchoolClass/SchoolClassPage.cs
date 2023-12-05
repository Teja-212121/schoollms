using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Schools.Pages;

[PageAuthorize(typeof(SchoolClassRow))]
public class SchoolClassPage : Controller
{
    [Route("Schools/SchoolClass")]
    public ActionResult Index()
    {
        return this.GridPage("@/Schools/SchoolClass/SchoolClassPage",
            SchoolClassRow.Fields.PageTitle());
    }
}