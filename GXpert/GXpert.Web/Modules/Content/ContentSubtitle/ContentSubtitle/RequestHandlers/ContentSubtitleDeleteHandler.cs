using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentSubtitleRow;

namespace GXpert.Content;

public interface IContentSubtitleDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentSubtitleDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentSubtitleDeleteHandler
{
    public ContentSubtitleDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}