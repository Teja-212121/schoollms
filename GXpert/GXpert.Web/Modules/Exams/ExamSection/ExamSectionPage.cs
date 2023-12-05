using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Exams.Pages;

[PageAuthorize(typeof(ExamSectionRow))]
public class ExamSectionPage : Controller
{
    [Route("Exams/ExamSection")]
    public ActionResult Index()
    {
        return this.GridPage("@/Exams/ExamSection/ExamSectionPage",
            ExamSectionRow.Fields.PageTitle());
    }
}