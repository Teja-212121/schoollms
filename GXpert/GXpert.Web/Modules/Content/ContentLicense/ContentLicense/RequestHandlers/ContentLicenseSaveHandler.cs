using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentLicenseRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentLicenseRow;

namespace GXpert.Content;

public interface IContentLicenseSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentLicenseSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentLicenseSaveHandler
{
    public ContentLicenseSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}