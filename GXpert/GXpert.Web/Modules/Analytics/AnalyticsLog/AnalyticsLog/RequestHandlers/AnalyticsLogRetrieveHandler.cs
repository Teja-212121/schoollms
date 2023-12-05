using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Analytics.AnalyticsLogRow>;
using MyRow = GXpert.Analytics.AnalyticsLogRow;

namespace GXpert.Analytics;

public interface IAnalyticsLogRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AnalyticsLogRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAnalyticsLogRetrieveHandler
{
    public AnalyticsLogRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}