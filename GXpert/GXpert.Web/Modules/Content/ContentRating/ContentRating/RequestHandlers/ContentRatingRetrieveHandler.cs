using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentRatingRow>;
using MyRow = GXpert.Content.ContentRatingRow;

namespace GXpert.Content;

public interface IContentRatingRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentRatingRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentRatingRetrieveHandler
{
    public ContentRatingRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}