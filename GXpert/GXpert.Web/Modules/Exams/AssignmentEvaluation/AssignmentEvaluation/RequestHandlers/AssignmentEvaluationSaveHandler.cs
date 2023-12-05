using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Exams.AssignmentEvaluationRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Exams.AssignmentEvaluationRow;

namespace GXpert.Exams;

public interface IAssignmentEvaluationSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AssignmentEvaluationSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAssignmentEvaluationSaveHandler
{
    public AssignmentEvaluationSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}