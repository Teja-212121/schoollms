using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentAudioRow;

namespace GXpert.Content;

public interface IContentAudioDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentAudioDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentAudioDeleteHandler
{
    public ContentAudioDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}