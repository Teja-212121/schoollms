using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Attendance.AssignmentAttemptEvaluationRow>;
using MyRow = GXpert.Attendance.AssignmentAttemptEvaluationRow;

namespace GXpert.Attendance;

public interface IAssignmentAttemptEvaluationListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentAttemptEvaluationListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentAttemptEvaluationListHandler
{
    public AssignmentAttemptEvaluationListHandler(IRequestContext context)
            : base(context)
    {
    }
}