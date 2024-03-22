using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Institute.BranchRow>;
using MyRow = GXpert.Institute.BranchRow;

namespace GXpert.Institute;

public interface IBranchListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class BranchListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBranchListHandler
{
    public BranchListHandler(IRequestContext context)
            : base(context)
    {
    }
}