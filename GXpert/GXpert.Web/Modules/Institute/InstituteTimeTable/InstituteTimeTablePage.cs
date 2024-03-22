using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Institute.Pages;

[PageAuthorize(typeof(InstituteTimeTableRow))]
public class InstituteTimeTablePage : Controller
{
    [Route("Institute/InstituteTimeTable")]
    public ActionResult Index()
    {
        return this.GridPage("@/Institute/InstituteTimeTable/InstituteTimeTablePage",
            InstituteTimeTableRow.Fields.PageTitle());
    }
}