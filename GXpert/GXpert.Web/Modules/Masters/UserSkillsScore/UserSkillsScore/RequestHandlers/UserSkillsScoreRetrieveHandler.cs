using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.UserSkillsScoreRow>;
using MyRow = GXpert.Masters.UserSkillsScoreRow;

namespace GXpert.Masters;

public interface IUserSkillsScoreRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class UserSkillsScoreRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserSkillsScoreRetrieveHandler
{
    public UserSkillsScoreRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}