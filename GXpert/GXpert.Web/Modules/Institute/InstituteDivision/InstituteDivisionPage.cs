using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Institute.Pages;

[PageAuthorize(typeof(InstituteDivisionRow))]
public class InstituteDivisionPage : Controller
{
    [Route("Institute/InstituteDivision")]
    public ActionResult Index()
    {
        return this.GridPage("@/Institute/InstituteDivision/InstituteDivisionPage",
            InstituteDivisionRow.Fields.PageTitle());
    }
}