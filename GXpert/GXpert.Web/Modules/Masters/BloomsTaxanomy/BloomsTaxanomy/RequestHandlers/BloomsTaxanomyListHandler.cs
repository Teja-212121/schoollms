using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.BloomsTaxanomyRow>;
using MyRow = GXpert.Masters.BloomsTaxanomyRow;

namespace GXpert.Masters;

public interface IBloomsTaxanomyListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class BloomsTaxanomyListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IBloomsTaxanomyListHandler
{
    public BloomsTaxanomyListHandler(IRequestContext context)
            : base(context)
    {
    }
}