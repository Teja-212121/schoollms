using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.UserSkillsScoreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.UserSkillsScoreRow;

namespace GXpert.Masters;

public interface IUserSkillsScoreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class UserSkillsScoreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUserSkillsScoreSaveHandler
{
    public UserSkillsScoreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}