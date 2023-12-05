using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(AcademicYearRow))]
public class AcademicYearPage : Controller
{
    [Route("Masters/AcademicYear")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/AcademicYear/AcademicYearPage",
            AcademicYearRow.Fields.PageTitle());
    }
}