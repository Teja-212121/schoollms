using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Administration.TenantRow>;
using MyRow = GXpert.Administration.TenantRow;

namespace GXpert.Administration;

public interface ITenantRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class TenantRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITenantRetrieveHandler
{
    public TenantRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}