using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentCommentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentCommentRow;

namespace GXpert.Content;

public interface IContentCommentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCommentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentCommentSaveHandler
{
    public ContentCommentSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}