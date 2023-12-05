using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Settings.SmtpRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Settings.SmtpRow;

namespace GXpert.Settings;

public interface ISmtpSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SmtpSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISmtpSaveHandler
{
    public SmtpSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}