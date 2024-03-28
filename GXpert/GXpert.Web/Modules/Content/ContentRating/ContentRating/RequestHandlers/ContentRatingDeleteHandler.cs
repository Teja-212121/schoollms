using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentRatingRow;

namespace GXpert.Content;

public interface IContentRatingDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentRatingDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentRatingDeleteHandler
{
    public ContentRatingDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}