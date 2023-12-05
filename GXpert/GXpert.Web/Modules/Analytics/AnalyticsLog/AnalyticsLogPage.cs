using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Analytics.Pages;

[PageAuthorize(typeof(AnalyticsLogRow))]
public class AnalyticsLogPage : Controller
{
    [Route("Analytics/AnalyticsLog")]
    public ActionResult Index()
    {
        return this.GridPage("@/Analytics/AnalyticsLog/AnalyticsLogPage",
            AnalyticsLogRow.Fields.PageTitle());
    }
}