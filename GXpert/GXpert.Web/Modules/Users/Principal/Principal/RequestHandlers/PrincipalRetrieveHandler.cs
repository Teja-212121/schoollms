using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Users.PrincipalRow>;
using MyRow = GXpert.Users.PrincipalRow;

namespace GXpert.Users;

public interface IPrincipalRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PrincipalRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPrincipalRetrieveHandler
{
    public PrincipalRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}