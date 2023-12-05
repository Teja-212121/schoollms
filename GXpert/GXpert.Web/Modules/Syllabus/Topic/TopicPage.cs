using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Syllabus.Pages;

[PageAuthorize(typeof(TopicRow))]
public class TopicPage : Controller
{
    [Route("Syllabus/Topic")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Topic/TopicPage",
            TopicRow.Fields.PageTitle());
    }
}