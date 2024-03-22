using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.ProjectSkillRow>;
using MyRow = GXpert.Masters.ProjectSkillRow;

namespace GXpert.Masters;

public interface IProjectSkillRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProjectSkillRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectSkillRetrieveHandler
{
    public ProjectSkillRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}