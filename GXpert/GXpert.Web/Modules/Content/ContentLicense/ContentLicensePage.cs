using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentLicenseRow))]
public class ContentLicensePage : Controller
{
    [Route("Content/ContentLicense")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentLicense/ContentLicensePage",
            ContentLicenseRow.Fields.PageTitle());
    }
}