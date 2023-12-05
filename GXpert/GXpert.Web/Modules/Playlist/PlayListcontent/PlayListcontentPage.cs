using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Playlist.Pages;

[PageAuthorize(typeof(PlayListContentRow))]
public class PlayListContentPage : Controller
{
    [Route("Playlist/PlayListContent")]
    public ActionResult Index()
    {
        return this.GridPage("@/Playlist/PlayListContent/PlayListContentPage",
            PlayListContentRow.Fields.PageTitle());
    }
}