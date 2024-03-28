using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Content.Pages;

[PageAuthorize(typeof(ContentLanguageRow))]
public class ContentLanguagePage : Controller
{
    [Route("Content/ContentLanguage")]
    public ActionResult Index()
    {
        return this.GridPage("@/Content/ContentLanguage/ContentLanguagePage",
            ContentLanguageRow.Fields.PageTitle());
    }
}