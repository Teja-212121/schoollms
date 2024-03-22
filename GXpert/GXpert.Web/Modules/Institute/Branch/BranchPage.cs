using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Institute.Pages;

[PageAuthorize(typeof(BranchRow))]
public class BranchPage : Controller
{
    [Route("Institute/Branch")]
    public ActionResult Index()
    {
        return this.GridPage("@/Institute/Branch/BranchPage",
            BranchRow.Fields.PageTitle());
    }
}