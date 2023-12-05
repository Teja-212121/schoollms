using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Attendance.AssignmentAttemptEvaluationRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Attendance.AssignmentAttemptEvaluationRow;

namespace GXpert.Attendance;

public interface IAssignmentAttemptEvaluationSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentAttemptEvaluationSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentAttemptEvaluationSaveHandler
{
    public AssignmentAttemptEvaluationSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}