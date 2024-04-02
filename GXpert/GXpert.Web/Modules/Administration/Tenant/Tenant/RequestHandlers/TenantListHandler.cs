using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Administration.TenantRow>;
using MyRow = GXpert.Administration.TenantRow;

namespace GXpert.Administration;

public interface ITenantListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class TenantListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITenantListHandler
{
    public TenantListHandler(IRequestContext context)
            : base(context)
    {
    }
}