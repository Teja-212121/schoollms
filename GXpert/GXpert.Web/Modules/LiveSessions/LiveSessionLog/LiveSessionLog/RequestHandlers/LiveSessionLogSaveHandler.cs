using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.LiveSessions.LiveSessionLogRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.LiveSessions.LiveSessionLogRow;

namespace GXpert.LiveSessions;

public interface ILiveSessionLogSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class LiveSessionLogSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILiveSessionLogSaveHandler
{
    public LiveSessionLogSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}