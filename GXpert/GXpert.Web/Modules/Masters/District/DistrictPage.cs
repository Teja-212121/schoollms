using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(DistrictRow))]
public class DistrictPage : Controller
{
    [Route("Masters/District")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/District/DistrictPage",
            DistrictRow.Fields.PageTitle());
    }
}