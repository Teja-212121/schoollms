using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.LiveSessions.LiveSessionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.LiveSessions.LiveSessionRow;

namespace GXpert.LiveSessions;

public interface ILiveSessionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class LiveSessionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILiveSessionSaveHandler
{
    public LiveSessionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}