using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentTopicRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentTopicRow;

namespace GXpert.Content;

public interface IContentTopicSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentTopicSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentTopicSaveHandler
{
    public ContentTopicSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}