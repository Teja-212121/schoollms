using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Users.HodRow>;
using MyRow = GXpert.Users.HodRow;

namespace GXpert.Users;

public interface IHodListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class HodListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IHodListHandler
{
    public HodListHandler(IRequestContext context)
            : base(context)
    {
    }
}