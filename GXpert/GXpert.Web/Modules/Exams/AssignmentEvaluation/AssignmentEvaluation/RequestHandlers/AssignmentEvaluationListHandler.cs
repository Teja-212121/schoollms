using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Exams.AssignmentEvaluationRow>;
using MyRow = GXpert.Exams.AssignmentEvaluationRow;

namespace GXpert.Exams;

public interface IAssignmentEvaluationListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentEvaluationListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentEvaluationListHandler
{
    public AssignmentEvaluationListHandler(IRequestContext context)
            : base(context)
    {
    }
}