using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Skills.Pages;

[PageAuthorize(typeof(SkillCategoryRow))]
public class SkillCategoryPage : Controller
{
    [Route("Skills/SkillCategory")]
    public ActionResult Index()
    {
        return this.GridPage("@/Skills/SkillCategory/SkillCategoryPage",
            SkillCategoryRow.Fields.PageTitle());
    }
}