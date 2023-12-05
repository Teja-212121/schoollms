using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Attendance.RaiseHandLiveSessionRow>;
using MyRow = GXpert.Attendance.RaiseHandLiveSessionRow;

namespace GXpert.Attendance;

public interface IRaiseHandLiveSessionListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class RaiseHandLiveSessionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IRaiseHandLiveSessionListHandler
{
    public RaiseHandLiveSessionListHandler(IRequestContext context)
            : base(context)
    {
    }
}