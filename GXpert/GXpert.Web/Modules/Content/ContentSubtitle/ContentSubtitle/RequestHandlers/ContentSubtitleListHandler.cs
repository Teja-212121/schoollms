using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentSubtitleRow>;
using MyRow = GXpert.Content.ContentSubtitleRow;

namespace GXpert.Content;

public interface IContentSubtitleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentSubtitleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentSubtitleListHandler
{
    public ContentSubtitleListHandler(IRequestContext context)
            : base(context)
    {
    }
}