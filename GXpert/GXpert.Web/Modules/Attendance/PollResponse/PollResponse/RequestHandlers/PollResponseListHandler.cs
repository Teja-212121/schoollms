using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Attendance.PollResponseRow>;
using MyRow = GXpert.Attendance.PollResponseRow;

namespace GXpert.Attendance;

public interface IPollResponseListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PollResponseListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPollResponseListHandler
{
    public PollResponseListHandler(IRequestContext context)
            : base(context)
    {
    }
}