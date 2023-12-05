using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Attendance.RaiseHandLiveSessionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Attendance.RaiseHandLiveSessionRow;

namespace GXpert.Attendance;

public interface IRaiseHandLiveSessionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class RaiseHandLiveSessionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRaiseHandLiveSessionSaveHandler
{
    public RaiseHandLiveSessionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}