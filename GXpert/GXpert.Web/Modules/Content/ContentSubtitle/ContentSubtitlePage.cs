using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentSubtitleRow))]
public class ContentSubtitlePage : Controller
{
    [Route("Content/ContentSubtitle")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentSubtitle/ContentSubtitlePage",
            ContentSubtitleRow.Fields.PageTitle());
    }
}