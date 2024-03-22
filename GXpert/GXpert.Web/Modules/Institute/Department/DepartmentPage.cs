using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Institute.Pages;

[PageAuthorize(typeof(DepartmentRow))]
public class DepartmentPage : Controller
{
    [Route("Institute/Department")]
    public ActionResult Index()
    {
        return this.GridPage("@/Institute/Department/DepartmentPage",
            DepartmentRow.Fields.PageTitle());
    }
}