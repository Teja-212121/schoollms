using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.LiveSessions.PollRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.LiveSessions.PollRow;

namespace GXpert.LiveSessions;

public interface IPollSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PollSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPollSaveHandler
{
    public PollSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}