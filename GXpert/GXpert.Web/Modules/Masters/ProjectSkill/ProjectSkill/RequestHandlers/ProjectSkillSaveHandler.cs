using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.ProjectSkillRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.ProjectSkillRow;

namespace GXpert.Masters;

public interface IProjectSkillSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProjectSkillSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectSkillSaveHandler
{
    public ProjectSkillSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}