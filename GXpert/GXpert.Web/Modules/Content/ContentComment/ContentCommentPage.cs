using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentCommentRow))]
public class ContentCommentPage : Controller
{
    [Route("Content/ContentComment")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentComment/ContentCommentPage",
            ContentCommentRow.Fields.PageTitle());
    }
}