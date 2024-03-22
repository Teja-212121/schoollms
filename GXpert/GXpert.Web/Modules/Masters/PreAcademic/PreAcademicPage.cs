using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(PreAcademicRow))]
public class PreAcademicPage : Controller
{
    [Route("Masters/PreAcademic")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/PreAcademic/PreAcademicPage",
            PreAcademicRow.Fields.PageTitle());
    }
}