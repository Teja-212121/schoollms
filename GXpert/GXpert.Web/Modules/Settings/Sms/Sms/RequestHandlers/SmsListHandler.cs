using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Settings.SmsRow>;
using MyRow = GXpert.Settings.SmsRow;

namespace GXpert.Settings;

public interface ISmsListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SmsListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISmsListHandler
{
    public SmsListHandler(IRequestContext context)
            : base(context)
    {
    }
}