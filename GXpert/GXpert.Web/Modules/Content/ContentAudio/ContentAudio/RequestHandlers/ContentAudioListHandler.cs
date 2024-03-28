using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentAudioRow>;
using MyRow = GXpert.Content.ContentAudioRow;

namespace GXpert.Content;

public interface IContentAudioListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentAudioListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentAudioListHandler
{
    public ContentAudioListHandler(IRequestContext context)
            : base(context)
    {
    }
}