using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.QuestionBank.Pages;

[PageAuthorize(typeof(QuestionRow))]
public class QuestionPage : Controller
{
    [Route("QuestionBank/Question")]
    public ActionResult Index()
    {
        return this.GridPage("@/QuestionBank/Question/QuestionPage",
            QuestionRow.Fields.PageTitle());
    }
}