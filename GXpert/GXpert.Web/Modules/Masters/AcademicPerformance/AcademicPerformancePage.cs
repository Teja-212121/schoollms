using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(AcademicPerformanceRow))]
public class AcademicPerformancePage : Controller
{
    [Route("Masters/AcademicPerformance")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/AcademicPerformance/AcademicPerformancePage",
            AcademicPerformanceRow.Fields.PageTitle());
    }
}