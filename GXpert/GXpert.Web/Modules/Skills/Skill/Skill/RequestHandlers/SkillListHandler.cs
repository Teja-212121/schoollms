using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Skills.SkillRow>;
using MyRow = GXpert.Skills.SkillRow;

namespace GXpert.Skills;

public interface ISkillListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SkillListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISkillListHandler
{
    public SkillListHandler(IRequestContext context)
            : base(context)
    {
    }
}