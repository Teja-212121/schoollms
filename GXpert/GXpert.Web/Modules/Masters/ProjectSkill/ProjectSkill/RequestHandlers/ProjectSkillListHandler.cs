using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.ProjectSkillRow>;
using MyRow = GXpert.Masters.ProjectSkillRow;

namespace GXpert.Masters;

public interface IProjectSkillListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProjectSkillListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProjectSkillListHandler
{
    public ProjectSkillListHandler(IRequestContext context)
            : base(context)
    {
    }
}