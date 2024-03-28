using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentCommentRow;

namespace GXpert.Content;

public interface IContentCommentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCommentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentCommentDeleteHandler
{
    public ContentCommentDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}