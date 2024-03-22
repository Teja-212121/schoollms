using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.ProjectRow>;
using MyRow = GXpert.Masters.ProjectRow;

namespace GXpert.Masters;

public interface IProjectListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ProjectListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProjectListHandler
{
    public ProjectListHandler(IRequestContext context)
            : base(context)
    {
    }
}