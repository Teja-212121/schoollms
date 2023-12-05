using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Attendance.AssignmentAttemptRow>;
using MyRow = GXpert.Attendance.AssignmentAttemptRow;

namespace GXpert.Attendance;

public interface IAssignmentAttemptListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentAttemptListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentAttemptListHandler
{
    public AssignmentAttemptListHandler(IRequestContext context)
            : base(context)
    {
    }
}