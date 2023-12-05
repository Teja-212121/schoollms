using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Attendance.AssignmentAttemptRow;

namespace GXpert.Attendance;

public interface IAssignmentAttemptDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentAttemptDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentAttemptDeleteHandler
{
    public AssignmentAttemptDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}