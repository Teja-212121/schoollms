using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Settings.Pages;

[PageAuthorize(typeof(StorageRow))]
public class StoragePage : Controller
{
    [Route("Settings/Storage")]
    public ActionResult Index()
    {
        return this.GridPage("@/Settings/Storage/StoragePage",
            StorageRow.Fields.PageTitle());
    }
}