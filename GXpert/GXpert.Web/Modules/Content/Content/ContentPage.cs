using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentRow))]
public class ContentPage : Controller
{
    [Route("Content/Content")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/Content/ContentPage",
            ContentRow.Fields.PageTitle());
    }
}