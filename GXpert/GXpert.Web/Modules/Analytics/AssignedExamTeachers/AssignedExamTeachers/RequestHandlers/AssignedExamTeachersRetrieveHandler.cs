using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Analytics.AssignedExamTeachersRow>;
using MyRow = GXpert.Analytics.AssignedExamTeachersRow;

namespace GXpert.Analytics;

public interface IAssignedExamTeachersRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignedExamTeachersRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignedExamTeachersRetrieveHandler
{
    public AssignedExamTeachersRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}