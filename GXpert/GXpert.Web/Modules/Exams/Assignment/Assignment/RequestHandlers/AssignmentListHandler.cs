using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Exams.AssignmentRow>;
using MyRow = GXpert.Exams.AssignmentRow;

namespace GXpert.Exams;

public interface IAssignmentListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentListHandler
{
    public AssignmentListHandler(IRequestContext context)
            : base(context)
    {
    }
}