using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Analytics.AnalyticsLogRow;

namespace GXpert.Analytics;

public interface IAnalyticsLogDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AnalyticsLogDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAnalyticsLogDeleteHandler
{
    public AnalyticsLogDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}