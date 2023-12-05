using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Analytics.ExamAttemptQuestionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Analytics.ExamAttemptQuestionRow;

namespace GXpert.Analytics;

public interface IExamAttemptQuestionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamAttemptQuestionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptQuestionSaveHandler
{
    public ExamAttemptQuestionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}