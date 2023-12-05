using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Analytics.ExamAttemptRow>;
using MyRow = GXpert.Analytics.ExamAttemptRow;

namespace GXpert.Analytics;

public interface IExamAttemptListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ExamAttemptListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamAttemptListHandler
{
    public ExamAttemptListHandler(IRequestContext context)
            : base(context)
    {
    }
}