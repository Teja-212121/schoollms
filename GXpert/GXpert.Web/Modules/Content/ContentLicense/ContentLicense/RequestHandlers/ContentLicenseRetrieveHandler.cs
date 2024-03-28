using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentLicenseRow>;
using MyRow = GXpert.Content.ContentLicenseRow;

namespace GXpert.Content;

public interface IContentLicenseRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentLicenseRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentLicenseRetrieveHandler
{
    public ContentLicenseRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}