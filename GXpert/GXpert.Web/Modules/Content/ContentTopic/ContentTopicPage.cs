using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentTopicRow))]
public class ContentTopicPage : Controller
{
    [Route("Content/ContentTopic")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentTopic/ContentTopicPage",
            ContentTopicRow.Fields.PageTitle());
    }
}