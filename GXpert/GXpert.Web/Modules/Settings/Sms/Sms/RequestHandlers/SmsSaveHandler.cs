using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Settings.SmsRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Settings.SmsRow;

namespace GXpert.Settings;

public interface ISmsSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SmsSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISmsSaveHandler
{
    public SmsSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}