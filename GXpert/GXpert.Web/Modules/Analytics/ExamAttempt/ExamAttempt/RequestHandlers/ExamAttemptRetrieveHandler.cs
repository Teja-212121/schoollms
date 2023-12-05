using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Analytics.ExamAttemptRow>;
using MyRow = GXpert.Analytics.ExamAttemptRow;

namespace GXpert.Analytics;

public interface IExamAttemptRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ExamAttemptRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptRetrieveHandler
{
    public ExamAttemptRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}