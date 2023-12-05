using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentBloomsIndexRow))]
public class ContentBloomsIndexPage : Controller
{
    [Route("Content/ContentBloomsIndex")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentBloomsIndex/ContentBloomsIndexPage",
            ContentBloomsIndexRow.Fields.PageTitle());
    }
}