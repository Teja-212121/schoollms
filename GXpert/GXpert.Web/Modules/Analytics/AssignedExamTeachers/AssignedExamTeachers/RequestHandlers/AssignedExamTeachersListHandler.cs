using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Analytics.AssignedExamTeachersRow>;
using MyRow = GXpert.Analytics.AssignedExamTeachersRow;

namespace GXpert.Analytics;

public interface IAssignedExamTeachersListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AssignedExamTeachersListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAssignedExamTeachersListHandler
{
    public AssignedExamTeachersListHandler(IRequestContext context)
            : base(context)
    {
    }
}