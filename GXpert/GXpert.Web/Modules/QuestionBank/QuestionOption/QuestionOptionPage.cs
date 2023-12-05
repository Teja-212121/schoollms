using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.QuestionBank.Pages;

[PageAuthorize(typeof(QuestionOptionRow))]
public class QuestionOptionPage : Controller
{
    [Route("QuestionBank/QuestionOption")]
    public ActionResult Index()
    {
        return this.GridPage("@/QuestionBank/QuestionOption/QuestionOptionPage",
            QuestionOptionRow.Fields.PageTitle());
    }
}