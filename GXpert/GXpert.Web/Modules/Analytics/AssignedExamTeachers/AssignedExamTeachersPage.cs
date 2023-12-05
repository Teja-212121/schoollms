using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Analytics.Pages;

[PageAuthorize(typeof(AssignedExamTeachersRow))]
public class AssignedExamTeachersPage : Controller
{
    [Route("Analytics/AssignedExamTeachers")]
    public ActionResult Index()
    {
        return this.GridPage("@/Analytics/AssignedExamTeachers/AssignedExamTeachersPage",
            AssignedExamTeachersRow.Fields.PageTitle());
    }
}