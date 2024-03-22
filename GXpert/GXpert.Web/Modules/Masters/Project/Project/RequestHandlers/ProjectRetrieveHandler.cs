using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.ProjectRow>;
using MyRow = GXpert.Masters.ProjectRow;

namespace GXpert.Masters;

public interface IProjectRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ProjectRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProjectRetrieveHandler
{
    public ProjectRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}