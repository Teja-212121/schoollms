using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentCategoryRow>;
using MyRow = GXpert.Content.ContentCategoryRow;

namespace GXpert.Content;

public interface IContentCategoryListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCategoryListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentCategoryListHandler
{
    public ContentCategoryListHandler(IRequestContext context)
            : base(context)
    {
    }
}