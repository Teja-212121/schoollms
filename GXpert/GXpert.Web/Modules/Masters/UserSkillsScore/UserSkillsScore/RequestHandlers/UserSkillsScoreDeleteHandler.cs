using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.UserSkillsScoreRow;

namespace GXpert.Masters;

public interface IUserSkillsScoreDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class UserSkillsScoreDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUserSkillsScoreDeleteHandler
{
    public UserSkillsScoreDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}