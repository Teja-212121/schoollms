using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Activation.Pages;

[PageAuthorize(typeof(CouponCodeRow))]
public class CouponCodePage : Controller
{
    [Route("Activation/CouponCode")]
    public ActionResult Index()
    {
        return this.GridPage("@/Activation/CouponCode/CouponCodePage",
            CouponCodeRow.Fields.PageTitle());
    }
}