using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentCommentRow>;
using MyRow = GXpert.Content.ContentCommentRow;

namespace GXpert.Content;

public interface IContentCommentListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCommentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentCommentListHandler
{
    public ContentCommentListHandler(IRequestContext context)
            : base(context)
    {
    }
}