using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Analytics.ExamAttemptRow;

namespace GXpert.Analytics;

public interface IExamAttemptDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ExamAttemptDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptDeleteHandler
{
    public ExamAttemptDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}