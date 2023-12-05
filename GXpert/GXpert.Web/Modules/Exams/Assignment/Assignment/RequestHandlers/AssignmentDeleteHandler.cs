using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Exams.AssignmentRow;

namespace GXpert.Exams;

public interface IAssignmentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentDeleteHandler
{
    public AssignmentDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}