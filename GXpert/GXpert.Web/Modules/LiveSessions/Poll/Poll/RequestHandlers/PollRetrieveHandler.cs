using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.LiveSessions.PollRow>;
using MyRow = GXpert.LiveSessions.PollRow;

namespace GXpert.LiveSessions;

public interface IPollRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PollRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPollRetrieveHandler
{
    public PollRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}