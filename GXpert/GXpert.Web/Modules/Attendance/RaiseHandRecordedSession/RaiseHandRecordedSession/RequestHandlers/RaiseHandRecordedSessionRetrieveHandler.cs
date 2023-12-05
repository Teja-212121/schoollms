using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Attendance.RaiseHandRecordedSessionRow>;
using MyRow = GXpert.Attendance.RaiseHandRecordedSessionRow;

namespace GXpert.Attendance;

public interface IRaiseHandRecordedSessionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class RaiseHandRecordedSessionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRaiseHandRecordedSessionRetrieveHandler
{
    public RaiseHandRecordedSessionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}