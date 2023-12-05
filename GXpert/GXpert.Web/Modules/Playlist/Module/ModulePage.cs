using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Playlist.Pages;

[PageAuthorize(typeof(ModuleRow))]
public class ModulePage : Controller
{
    [Route("Playlist/Module")]
    public ActionResult Index()
    {
        return this.GridPage("@/Playlist/Module/ModulePage",
            ModuleRow.Fields.PageTitle());
    }
}