using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.LiveSessions.LiveSessionRow;

namespace GXpert.LiveSessions;

public interface ILiveSessionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class LiveSessionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ILiveSessionDeleteHandler
{
    public LiveSessionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}