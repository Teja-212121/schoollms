using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Institute.Pages;

[PageAuthorize(typeof(InstituteRow))]
public class InstitutePage : Controller
{
    [Route("Institute/Institute")]
    public ActionResult Index()
    {
        return this.GridPage("@/Institute/Institute/InstitutePage",
            InstituteRow.Fields.PageTitle());
    }
}