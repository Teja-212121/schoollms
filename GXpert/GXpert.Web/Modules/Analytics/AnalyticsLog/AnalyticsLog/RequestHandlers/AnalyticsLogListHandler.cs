using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Analytics.AnalyticsLogRow>;
using MyRow = GXpert.Analytics.AnalyticsLogRow;

namespace GXpert.Analytics;

public interface IAnalyticsLogListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AnalyticsLogListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAnalyticsLogListHandler
{
    public AnalyticsLogListHandler(IRequestContext context)
            : base(context)
    {
    }
}