using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.LiveSessions.LiveSessionRow>;
using MyRow = GXpert.LiveSessions.LiveSessionRow;

namespace GXpert.LiveSessions;

public interface ILiveSessionListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LiveSessionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILiveSessionListHandler
{
    public LiveSessionListHandler(IRequestContext context)
            : base(context)
    {
    }
}