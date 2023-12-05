using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Analytics.ExamAttemptQuestionRow;

namespace GXpert.Analytics;

public interface IExamAttemptQuestionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ExamAttemptQuestionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptQuestionDeleteHandler
{
    public ExamAttemptQuestionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}