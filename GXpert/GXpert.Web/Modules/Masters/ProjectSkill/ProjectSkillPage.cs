using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(ProjectSkillRow))]
public class ProjectSkillPage : Controller
{
    [Route("Masters/ProjectSkill")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/ProjectSkill/ProjectSkillPage",
            ProjectSkillRow.Fields.PageTitle());
    }
}