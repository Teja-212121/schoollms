using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.LiveSessions.LiveSessionLogRow>;
using MyRow = GXpert.LiveSessions.LiveSessionLogRow;

namespace GXpert.LiveSessions;

public interface ILiveSessionLogRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class LiveSessionLogRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILiveSessionLogRetrieveHandler
{
    public LiveSessionLogRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}