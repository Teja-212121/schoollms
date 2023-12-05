using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.QuestionBank.Pages;

[PageAuthorize(typeof(CommonDataRow))]
public class CommonDataPage : Controller
{
    [Route("QuestionBank/CommonData")]
    public ActionResult Index()
    {
        return this.GridPage("@/QuestionBank/CommonData/CommonDataPage",
            CommonDataRow.Fields.PageTitle());
    }
}