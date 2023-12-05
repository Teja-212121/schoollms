using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.DistrictRow>;
using MyRow = GXpert.Masters.DistrictRow;

namespace GXpert.Masters;

public interface IDistrictRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class DistrictRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictRetrieveHandler
{
    public DistrictRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}