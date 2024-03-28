using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentCategoryRow;

namespace GXpert.Content;

public interface IContentCategoryDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCategoryDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentCategoryDeleteHandler
{
    public ContentCategoryDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}