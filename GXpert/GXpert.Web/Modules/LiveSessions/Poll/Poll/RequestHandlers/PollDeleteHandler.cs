using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.LiveSessions.PollRow;

namespace GXpert.LiveSessions;

public interface IPollDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PollDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPollDeleteHandler
{
    public PollDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}