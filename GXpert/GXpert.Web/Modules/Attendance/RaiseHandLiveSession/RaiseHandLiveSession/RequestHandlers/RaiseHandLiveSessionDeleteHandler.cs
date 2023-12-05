using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Attendance.RaiseHandLiveSessionRow;

namespace GXpert.Attendance;

public interface IRaiseHandLiveSessionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class RaiseHandLiveSessionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRaiseHandLiveSessionDeleteHandler
{
    public RaiseHandLiveSessionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}