using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentAudioRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentAudioRow;

namespace GXpert.Content;

public interface IContentAudioSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentAudioSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentAudioSaveHandler
{
    public ContentAudioSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}