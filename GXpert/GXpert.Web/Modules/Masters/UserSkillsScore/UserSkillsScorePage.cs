using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace GXpert.Masters.Pages;

[PageAuthorize(typeof(UserSkillsScoreRow))]
public class UserSkillsScorePage : Controller
{
    [Route("Masters/UserSkillsScore")]
    public ActionResult Index()
    {
        return this.GridPage("@/Masters/UserSkillsScore/UserSkillsScorePage",
            UserSkillsScoreRow.Fields.PageTitle());
    }
}