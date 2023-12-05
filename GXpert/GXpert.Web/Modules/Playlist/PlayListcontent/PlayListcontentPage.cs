using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Playlist.Pages;

[PageAuthorize(typeof(PlayListcontentRow))]
public class PlayListcontentPage : Controller
{
    [Route("Playlist/PlayListcontent")]
    public ActionResult Index()
    {
        return this.GridPage("@/Playlist/PlayListcontent/PlayListcontentPage",
            PlayListcontentRow.Fields.PageTitle());
    }
}