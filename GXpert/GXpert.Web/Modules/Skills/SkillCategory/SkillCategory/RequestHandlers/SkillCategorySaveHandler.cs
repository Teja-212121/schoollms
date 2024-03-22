using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Skills.SkillCategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Skills.SkillCategoryRow;

namespace GXpert.Skills;

public interface ISkillCategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SkillCategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISkillCategorySaveHandler
{
    public SkillCategorySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}