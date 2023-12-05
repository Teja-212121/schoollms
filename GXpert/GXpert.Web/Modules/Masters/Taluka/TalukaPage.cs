using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(TalukaRow))]
public class TalukaPage : Controller
{
    [Route("Masters/Taluka")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/Taluka/TalukaPage",
            TalukaRow.Fields.PageTitle());
    }
}