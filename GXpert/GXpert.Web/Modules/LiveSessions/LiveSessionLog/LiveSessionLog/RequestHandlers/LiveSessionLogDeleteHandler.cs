using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.LiveSessions.LiveSessionLogRow;

namespace GXpert.LiveSessions;

public interface ILiveSessionLogDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class LiveSessionLogDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILiveSessionLogDeleteHandler
{
    public LiveSessionLogDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}