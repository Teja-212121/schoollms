using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Attendance.RaiseHandRecordedSessionRow>;
using MyRow = GXpert.Attendance.RaiseHandRecordedSessionRow;

namespace GXpert.Attendance;

public interface IRaiseHandRecordedSessionListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RaiseHandRecordedSessionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRaiseHandRecordedSessionListHandler
{
    public RaiseHandRecordedSessionListHandler(IRequestContext context)
            : base(context)
    {
    }
}