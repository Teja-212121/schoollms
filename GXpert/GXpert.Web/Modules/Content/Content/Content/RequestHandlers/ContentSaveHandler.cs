using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentRow;

namespace GXpert.Content;

public interface IContentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentSaveHandler
{
    public ContentSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}