using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Attendance.RaiseHandLiveSessionRow>;
using MyRow = GXpert.Attendance.RaiseHandLiveSessionRow;

namespace GXpert.Attendance;

public interface IRaiseHandLiveSessionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class RaiseHandLiveSessionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IRaiseHandLiveSessionRetrieveHandler
{
    public RaiseHandLiveSessionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}