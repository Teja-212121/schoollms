using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentCategoryRow))]
public class ContentCategoryPage : Controller
{
    [Route("Content/ContentCategory")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentCategory/ContentCategoryPage",
            ContentCategoryRow.Fields.PageTitle());
    }
}