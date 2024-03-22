using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Users.PrincipalRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Users.PrincipalRow;

namespace GXpert.Users;

public interface IPrincipalSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PrincipalSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPrincipalSaveHandler
{
    public PrincipalSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}