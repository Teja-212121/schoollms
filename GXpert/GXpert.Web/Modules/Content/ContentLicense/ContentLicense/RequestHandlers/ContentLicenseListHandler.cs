using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentLicenseRow>;
using MyRow = GXpert.Content.ContentLicenseRow;

namespace GXpert.Content;

public interface IContentLicenseListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentLicenseListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentLicenseListHandler
{
    public ContentLicenseListHandler(IRequestContext context)
            : base(context)
    {
    }
}