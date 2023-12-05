using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Exams.AssignmentEvaluationRow>;
using MyRow = GXpert.Exams.AssignmentEvaluationRow;

namespace GXpert.Exams;

public interface IAssignmentEvaluationRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentEvaluationRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentEvaluationRetrieveHandler
{
    public AssignmentEvaluationRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}