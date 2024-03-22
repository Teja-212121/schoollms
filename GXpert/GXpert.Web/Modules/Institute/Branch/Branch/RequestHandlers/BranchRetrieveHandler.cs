using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Institute.BranchRow>;
using MyRow = GXpert.Institute.BranchRow;

namespace GXpert.Institute;

public interface IBranchRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class BranchRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBranchRetrieveHandler
{
    public BranchRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}