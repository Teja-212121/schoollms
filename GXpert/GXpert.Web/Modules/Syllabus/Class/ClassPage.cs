using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Syllabus.Pages;

[PageAuthorize(typeof(ClassRow))]
public class ClassPage : Controller
{
    [Route("Syllabus/Class")]
    public ActionResult Index()
    {
        return this.GridPage("@/Syllabus/Class/ClassPage",
            ClassRow.Fields.PageTitle());
    }
}