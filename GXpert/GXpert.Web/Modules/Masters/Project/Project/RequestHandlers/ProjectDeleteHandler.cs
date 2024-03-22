using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.ProjectRow;

namespace GXpert.Masters;

public interface IProjectDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ProjectDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProjectDeleteHandler
{
    public ProjectDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}