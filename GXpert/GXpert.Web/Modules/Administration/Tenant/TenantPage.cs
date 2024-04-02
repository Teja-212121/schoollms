using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Administration.Pages;

[PageAuthorize(typeof(TenantRow))]
public class TenantPage : Controller
{
    [Route("Administration/Tenant")]
    public ActionResult Index()
    {
        return this.GridPage("@/Administration/Tenant/TenantPage",
            TenantRow.Fields.PageTitle());
    }
}