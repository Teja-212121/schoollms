using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentRatingRow))]
public class ContentRatingPage : Controller
{
    [Route("Content/ContentRating")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentRating/ContentRatingPage",
            ContentRatingRow.Fields.PageTitle());
    }
}