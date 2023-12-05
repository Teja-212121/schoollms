using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Analytics.AssignedExamTeachersRow;

namespace GXpert.Analytics;

public interface IAssignedExamTeachersDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AssignedExamTeachersDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAssignedExamTeachersDeleteHandler
{
    public AssignedExamTeachersDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}