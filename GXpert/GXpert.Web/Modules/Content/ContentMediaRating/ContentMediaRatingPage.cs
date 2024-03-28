using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentMediaRatingRow))]
public class ContentMediaRatingPage : Controller
{
    [Route("Content/ContentMediaRating")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentMediaRating/ContentMediaRatingPage",
            ContentMediaRatingRow.Fields.PageTitle());
    }
}