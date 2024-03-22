using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.ProjectSkillRow;

namespace GXpert.Masters;

public interface IProjectSkillDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ProjectSkillDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProjectSkillDeleteHandler
{
    public ProjectSkillDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}