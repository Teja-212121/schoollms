using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentMediaRatingRow;

namespace GXpert.Content;

public interface IContentMediaRatingDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentMediaRatingDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentMediaRatingDeleteHandler
{
    public ContentMediaRatingDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}