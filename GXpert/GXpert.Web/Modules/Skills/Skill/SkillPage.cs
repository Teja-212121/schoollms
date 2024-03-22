using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Skills.Pages;

[PageAuthorize(typeof(SkillRow))]
public class SkillPage : Controller
{
    [Route("Skills/Skill")]
    public ActionResult Index()
    {
        return this.GridPage("@/Skills/Skill/SkillPage",
            SkillRow.Fields.PageTitle());
    }
}