using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentAudioRow>;
using MyRow = GXpert.Content.ContentAudioRow;

namespace GXpert.Content;

public interface IContentAudioRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentAudioRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentAudioRetrieveHandler
{
    public ContentAudioRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}