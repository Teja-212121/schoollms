using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.LiveSessions.LiveSessionLogRow>;
using MyRow = GXpert.LiveSessions.LiveSessionLogRow;

namespace GXpert.LiveSessions;

public interface ILiveSessionLogListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class LiveSessionLogListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILiveSessionLogListHandler
{
    public LiveSessionLogListHandler(IRequestContext context)
            : base(context)
    {
    }
}