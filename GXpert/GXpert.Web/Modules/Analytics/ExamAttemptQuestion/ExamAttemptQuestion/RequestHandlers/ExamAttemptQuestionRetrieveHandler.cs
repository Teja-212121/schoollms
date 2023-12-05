using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Analytics.ExamAttemptQuestionRow>;
using MyRow = GXpert.Analytics.ExamAttemptQuestionRow;

namespace GXpert.Analytics;

public interface IExamAttemptQuestionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamAttemptQuestionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptQuestionRetrieveHandler
{
    public ExamAttemptQuestionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}