using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Analytics.ExamAttemptRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Analytics.ExamAttemptRow;

namespace GXpert.Analytics;

public interface IExamAttemptSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamAttemptSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptSaveHandler
{
    public ExamAttemptSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}