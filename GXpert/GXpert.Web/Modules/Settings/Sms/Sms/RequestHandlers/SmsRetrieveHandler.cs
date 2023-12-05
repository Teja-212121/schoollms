using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Settings.SmsRow>;
using MyRow = GXpert.Settings.SmsRow;

namespace GXpert.Settings;

public interface ISmsRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SmsRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISmsRetrieveHandler
{
    public SmsRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}