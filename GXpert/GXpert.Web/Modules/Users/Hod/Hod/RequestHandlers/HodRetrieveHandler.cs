using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Users.HodRow>;
using MyRow = GXpert.Users.HodRow;

namespace GXpert.Users;

public interface IHodRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class HodRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IHodRetrieveHandler
{
    public HodRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}