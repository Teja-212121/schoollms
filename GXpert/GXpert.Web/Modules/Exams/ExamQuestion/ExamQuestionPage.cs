using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Exams.Pages;

[PageAuthorize(typeof(ExamQuestionRow))]
public class ExamQuestionPage : Controller
{
    [Route("Exams/ExamQuestion")]
    public ActionResult Index()
    {
        return this.GridPage("@/Exams/ExamQuestion/ExamQuestionPage",
            ExamQuestionRow.Fields.PageTitle());
    }
}