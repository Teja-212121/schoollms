using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.ProjectRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.ProjectRow;

namespace GXpert.Masters;

public interface IProjectSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ProjectSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectSaveHandler
{
    public ProjectSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}