using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Attendance.AssignmentAttemptRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Attendance.AssignmentAttemptRow;

namespace GXpert.Attendance;

public interface IAssignmentAttemptSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentAttemptSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentAttemptSaveHandler
{
    public AssignmentAttemptSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}