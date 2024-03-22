using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Skills.SkillRow>;
using MyRow = GXpert.Skills.SkillRow;

namespace GXpert.Skills;

public interface ISkillRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SkillRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISkillRetrieveHandler
{
    public SkillRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}