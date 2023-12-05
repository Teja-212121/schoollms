using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.LiveSessions.PollRow>;
using MyRow = GXpert.LiveSessions.PollRow;

namespace GXpert.LiveSessions;

public interface IPollListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PollListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPollListHandler
{
    public PollListHandler(IRequestContext context)
            : base(context)
    {
    }
}