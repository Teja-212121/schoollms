using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Users.PrincipalRow>;
using MyRow = GXpert.Users.PrincipalRow;

namespace GXpert.Users;

public interface IPrincipalListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PrincipalListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPrincipalListHandler
{
    public PrincipalListHandler(IRequestContext context)
            : base(context)
    {
    }
}