using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(ProjectRow))]
public class ProjectPage : Controller
{
    [Route("Masters/Project")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/Project/ProjectPage",
            ProjectRow.Fields.PageTitle());
    }
}