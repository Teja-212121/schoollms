using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.DistrictRow>;
using MyRow = GXpert.Masters.DistrictRow;

namespace GXpert.Masters;

public interface IDistrictListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class DistrictListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictListHandler
{
    public DistrictListHandler(IRequestContext context)
            : base(context)
    {
    }
}