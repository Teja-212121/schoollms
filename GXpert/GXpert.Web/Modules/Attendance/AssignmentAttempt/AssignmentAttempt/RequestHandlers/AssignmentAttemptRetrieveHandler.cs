using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Attendance.AssignmentAttemptRow>;
using MyRow = GXpert.Attendance.AssignmentAttemptRow;

namespace GXpert.Attendance;

public interface IAssignmentAttemptRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentAttemptRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentAttemptRetrieveHandler
{
    public AssignmentAttemptRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}