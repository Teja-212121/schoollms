using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Schools.Pages;

[PageAuthorize(typeof(SchoolTimeTableRow))]
public class SchoolTimeTablePage : Controller
{
    [Route("Schools/SchoolTimeTable")]
    public ActionResult Index()
    {
        return this.GridPage("@/Schools/SchoolTimeTable/SchoolTimeTablePage",
            SchoolTimeTableRow.Fields.PageTitle());
    }
}