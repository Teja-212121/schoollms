using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Syllabus.Pages;

[PageAuthorize(typeof(MediumRow))]
public class MediumPage : Controller
{
    [Route("Syllabus/Medium")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Medium/MediumPage",
            MediumRow.Fields.PageTitle());
    }
}