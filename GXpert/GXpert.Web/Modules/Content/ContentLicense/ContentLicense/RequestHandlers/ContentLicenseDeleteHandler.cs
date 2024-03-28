using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentLicenseRow;

namespace GXpert.Content;

public interface IContentLicenseDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentLicenseDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentLicenseDeleteHandler
{
    public ContentLicenseDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}