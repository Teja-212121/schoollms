using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentCategoryRow>;
using MyRow = GXpert.Content.ContentCategoryRow;

namespace GXpert.Content;

public interface IContentCategoryRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCategoryRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentCategoryRetrieveHandler
{
    public ContentCategoryRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}