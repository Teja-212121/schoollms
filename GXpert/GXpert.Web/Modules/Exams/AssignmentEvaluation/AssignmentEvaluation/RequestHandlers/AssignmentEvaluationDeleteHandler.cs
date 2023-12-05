using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Exams.AssignmentEvaluationRow;

namespace GXpert.Exams;

public interface IAssignmentEvaluationDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentEvaluationDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentEvaluationDeleteHandler
{
    public AssignmentEvaluationDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}