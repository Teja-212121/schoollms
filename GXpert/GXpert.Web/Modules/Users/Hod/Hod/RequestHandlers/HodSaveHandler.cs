using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Users.HodRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Users.HodRow;

namespace GXpert.Users;

public interface IHodSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class HodSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IHodSaveHandler
{
    public HodSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}