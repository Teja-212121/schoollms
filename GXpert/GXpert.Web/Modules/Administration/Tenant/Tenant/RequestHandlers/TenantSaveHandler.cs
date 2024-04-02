using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Administration.TenantRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Administration.TenantRow;

namespace GXpert.Administration;

public interface ITenantSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class TenantSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITenantSaveHandler
{
    public TenantSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}