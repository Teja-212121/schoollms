using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentAudioRow))]
public class ContentAudioPage : Controller
{
    [Route("Content/ContentAudio")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentAudio/ContentAudioPage",
            ContentAudioRow.Fields.PageTitle());
    }
}