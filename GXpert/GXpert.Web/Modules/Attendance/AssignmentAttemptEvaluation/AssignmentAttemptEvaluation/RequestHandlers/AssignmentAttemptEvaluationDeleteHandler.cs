using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Attendance.AssignmentAttemptEvaluationRow;

namespace GXpert.Attendance;

public interface IAssignmentAttemptEvaluationDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentAttemptEvaluationDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentAttemptEvaluationDeleteHandler
{
    public AssignmentAttemptEvaluationDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}