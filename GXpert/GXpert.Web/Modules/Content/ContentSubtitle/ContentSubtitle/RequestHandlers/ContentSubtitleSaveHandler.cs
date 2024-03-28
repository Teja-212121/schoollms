using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentSubtitleRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentSubtitleRow;

namespace GXpert.Content;

public interface IContentSubtitleSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentSubtitleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentSubtitleSaveHandler
{
    public ContentSubtitleSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}