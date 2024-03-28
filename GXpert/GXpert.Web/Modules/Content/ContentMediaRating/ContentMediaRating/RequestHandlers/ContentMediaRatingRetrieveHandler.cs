using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentMediaRatingRow>;
using MyRow = GXpert.Content.ContentMediaRatingRow;

namespace GXpert.Content;

public interface IContentMediaRatingRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentMediaRatingRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentMediaRatingRetrieveHandler
{
    public ContentMediaRatingRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}