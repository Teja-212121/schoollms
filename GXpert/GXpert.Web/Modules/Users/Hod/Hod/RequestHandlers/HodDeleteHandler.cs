using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Users.HodRow;

namespace GXpert.Users;

public interface IHodDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class HodDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IHodDeleteHandler
{
    public HodDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}