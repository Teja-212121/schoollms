using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Skills.SkillRow;

namespace GXpert.Skills;

public interface ISkillDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SkillDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISkillDeleteHandler
{
    public SkillDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}