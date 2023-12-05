using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Attendance.PollResponseRow;

namespace GXpert.Attendance;

public interface IPollResponseDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PollResponseDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPollResponseDeleteHandler
{
    public PollResponseDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}