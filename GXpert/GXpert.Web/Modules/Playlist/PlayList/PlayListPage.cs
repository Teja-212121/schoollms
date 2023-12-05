using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Playlist.Pages;

[PageAuthorize(typeof(PlayListRow))]
public class PlayListPage : Controller
{
    [Route("Playlist/PlayList")]
    public ActionResult Index()
    {
        return this.GridPage("@/Playlist/PlayList/PlayListPage",
            PlayListRow.Fields.PageTitle());
    }
}