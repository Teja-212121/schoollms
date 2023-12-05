using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Analytics.ExamAttemptQuestionRow>;
using MyRow = GXpert.Analytics.ExamAttemptQuestionRow;

namespace GXpert.Analytics;

public interface IExamAttemptQuestionListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ExamAttemptQuestionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptQuestionListHandler
{
    public ExamAttemptQuestionListHandler(IRequestContext context)
            : base(context)
    {
    }
}