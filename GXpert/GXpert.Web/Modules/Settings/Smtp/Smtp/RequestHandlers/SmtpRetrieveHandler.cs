using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Settings.SmtpRow>;
using MyRow = GXpert.Settings.SmtpRow;

namespace GXpert.Settings;

public interface ISmtpRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SmtpRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISmtpRetrieveHandler
{
    public SmtpRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}