using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.LiveSessions.LiveSessionRow>;
using MyRow = GXpert.LiveSessions.LiveSessionRow;

namespace GXpert.LiveSessions;

public interface ILiveSessionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class LiveSessionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ILiveSessionRetrieveHandler
{
    public LiveSessionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}