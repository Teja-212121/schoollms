using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Exams.Pages;

[PageAuthorize(typeof(ExamRow))]
public class ExamPage : Controller
{
    [Route("Exams/Exam")]
    public ActionResult Index()
    {
        return this.GridPage("@/Exams/Exam/ExamPage",
            ExamRow.Fields.PageTitle());
    }
}