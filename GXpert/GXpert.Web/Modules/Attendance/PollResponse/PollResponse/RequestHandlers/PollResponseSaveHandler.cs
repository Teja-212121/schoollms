using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Attendance.PollResponseRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Attendance.PollResponseRow;

namespace GXpert.Attendance;

public interface IPollResponseSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PollResponseSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPollResponseSaveHandler
{
    public PollResponseSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}