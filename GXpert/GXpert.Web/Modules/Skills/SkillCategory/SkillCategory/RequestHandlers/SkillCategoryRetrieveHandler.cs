using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Skills.SkillCategoryRow>;
using MyRow = GXpert.Skills.SkillCategoryRow;

namespace GXpert.Skills;

public interface ISkillCategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SkillCategoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISkillCategoryRetrieveHandler
{
    public SkillCategoryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}