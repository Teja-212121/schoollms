using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Users.PrincipalRow;

namespace GXpert.Users;

public interface IPrincipalDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PrincipalDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPrincipalDeleteHandler
{
    public PrincipalDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}