using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.BloomsTaxanomyRow;

namespace GXpert.Masters;

public interface IBloomsTaxanomyDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class BloomsTaxanomyDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IBloomsTaxanomyDeleteHandler
{
    public BloomsTaxanomyDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}