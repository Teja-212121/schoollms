using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Settings.SmtpRow;

namespace GXpert.Settings;

public interface ISmtpDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SmtpDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISmtpDeleteHandler
{
    public SmtpDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}