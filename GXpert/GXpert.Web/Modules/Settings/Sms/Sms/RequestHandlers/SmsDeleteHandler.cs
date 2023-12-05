using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Settings.SmsRow;

namespace GXpert.Settings;

public interface ISmsDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SmsDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISmsDeleteHandler
{
    public SmsDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}