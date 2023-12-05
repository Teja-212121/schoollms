using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Analytics.AnalyticsLogRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Analytics.AnalyticsLogRow;

namespace GXpert.Analytics;

public interface IAnalyticsLogSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AnalyticsLogSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAnalyticsLogSaveHandler
{
    public AnalyticsLogSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}