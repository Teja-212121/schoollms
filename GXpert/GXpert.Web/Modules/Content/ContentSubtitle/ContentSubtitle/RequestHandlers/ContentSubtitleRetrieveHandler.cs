using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentSubtitleRow>;
using MyRow = GXpert.Content.ContentSubtitleRow;

namespace GXpert.Content;

public interface IContentSubtitleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentSubtitleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentSubtitleRetrieveHandler
{
    public ContentSubtitleRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}