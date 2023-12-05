using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.DistrictRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.DistrictRow;

namespace GXpert.Masters;

public interface IDistrictSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DistrictSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictSaveHandler
{
    public DistrictSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}