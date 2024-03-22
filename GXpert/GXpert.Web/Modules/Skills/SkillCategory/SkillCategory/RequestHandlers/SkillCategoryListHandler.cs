using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Skills.SkillCategoryRow>;
using MyRow = GXpert.Skills.SkillCategoryRow;

namespace GXpert.Skills;

public interface ISkillCategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SkillCategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISkillCategoryListHandler
{
    public SkillCategoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}