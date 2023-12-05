using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Settings.SmtpRow>;
using MyRow = GXpert.Settings.SmtpRow;

namespace GXpert.Settings;

public interface ISmtpListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SmtpListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISmtpListHandler
{
    public SmtpListHandler(IRequestContext context)
            : base(context)
    {
    }
}