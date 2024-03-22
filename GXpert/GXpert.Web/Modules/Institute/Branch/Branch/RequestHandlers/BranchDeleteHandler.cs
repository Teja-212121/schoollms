using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Institute.BranchRow;

namespace GXpert.Institute;

public interface IBranchDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class BranchDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBranchDeleteHandler
{
    public BranchDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}