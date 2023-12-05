using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Attendance.RaiseHandRecordedSessionRow;

namespace GXpert.Attendance;

public interface IRaiseHandRecordedSessionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class RaiseHandRecordedSessionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IRaiseHandRecordedSessionDeleteHandler
{
    public RaiseHandRecordedSessionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}