using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Institute.Pages;

[PageAuthorize(typeof(InstituteClassRow))]
public class InstituteClassPage : Controller
{
    [Route("Institute/InstituteClass")]
    public ActionResult Index()
    {
        return this.GridPage("@/Institute/InstituteClass/InstituteClassPage",
            InstituteClassRow.Fields.PageTitle());
    }
}