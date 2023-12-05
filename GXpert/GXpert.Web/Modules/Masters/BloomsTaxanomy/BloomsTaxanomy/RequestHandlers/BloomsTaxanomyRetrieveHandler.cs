using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.BloomsTaxanomyRow>;
using MyRow = GXpert.Masters.BloomsTaxanomyRow;

namespace GXpert.Masters;

public interface IBloomsTaxanomyRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class BloomsTaxanomyRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IBloomsTaxanomyRetrieveHandler
{
    public BloomsTaxanomyRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}