using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.BloomsTaxanomyRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.BloomsTaxanomyRow;

namespace GXpert.Masters;

public interface IBloomsTaxanomySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BloomsTaxanomySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBloomsTaxanomySaveHandler
{
    public BloomsTaxanomySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}