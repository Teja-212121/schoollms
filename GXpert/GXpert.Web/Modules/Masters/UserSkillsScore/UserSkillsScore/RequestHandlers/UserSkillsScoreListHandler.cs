using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.UserSkillsScoreRow>;
using MyRow = GXpert.Masters.UserSkillsScoreRow;

namespace GXpert.Masters;

public interface IUserSkillsScoreListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserSkillsScoreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserSkillsScoreListHandler
{
    public UserSkillsScoreListHandler(IRequestContext context)
            : base(context)
    {
    }
}