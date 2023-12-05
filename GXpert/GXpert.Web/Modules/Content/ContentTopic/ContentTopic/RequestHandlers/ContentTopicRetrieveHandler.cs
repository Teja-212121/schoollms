using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentTopicRow>;
using MyRow = GXpert.Content.ContentTopicRow;

namespace GXpert.Content;

public interface IContentTopicRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentTopicRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentTopicRetrieveHandler
{
    public ContentTopicRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}