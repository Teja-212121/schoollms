using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(BloomsTaxanomyRow))]
public class BloomsTaxanomyPage : Controller
{
    [Route("Masters/BloomsTaxanomy")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/BloomsTaxanomy/BloomsTaxanomyPage",
            BloomsTaxanomyRow.Fields.PageTitle());
    }
}