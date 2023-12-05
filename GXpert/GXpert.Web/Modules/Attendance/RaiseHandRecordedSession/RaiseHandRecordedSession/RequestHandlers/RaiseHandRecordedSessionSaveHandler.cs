using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Attendance.RaiseHandRecordedSessionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Attendance.RaiseHandRecordedSessionRow;

namespace GXpert.Attendance;

public interface IRaiseHandRecordedSessionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class RaiseHandRecordedSessionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IRaiseHandRecordedSessionSaveHandler
{
    public RaiseHandRecordedSessionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}