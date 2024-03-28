using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentCommentRow>;
using MyRow = GXpert.Content.ContentCommentRow;

namespace GXpert.Content;

public interface IContentCommentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCommentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentCommentRetrieveHandler
{
    public ContentCommentRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}