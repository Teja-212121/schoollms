using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Attendance.AssignmentAttemptEvaluationRow>;
using MyRow = GXpert.Attendance.AssignmentAttemptEvaluationRow;

namespace GXpert.Attendance;

public interface IAssignmentAttemptEvaluationRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentAttemptEvaluationRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentAttemptEvaluationRetrieveHandler
{
    public AssignmentAttemptEvaluationRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}