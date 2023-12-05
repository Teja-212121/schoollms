using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Schools.Pages;

[PageAuthorize(typeof(SchoolStudentRow))]
public class SchoolStudentPage : Controller
{
    [Route("Schools/SchoolStudent")]
    public ActionResult Index()
    {
        return this.GridPage("@/Schools/SchoolStudent/SchoolStudentPage",
            SchoolStudentRow.Fields.PageTitle());
    }
}