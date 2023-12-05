using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Attendance.PollResponseRow>;
using MyRow = GXpert.Attendance.PollResponseRow;

namespace GXpert.Attendance;

public interface IPollResponseRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PollResponseRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPollResponseRetrieveHandler
{
    public PollResponseRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}