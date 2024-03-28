using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentMediaRatingRow>;
using MyRow = GXpert.Content.ContentMediaRatingRow;

namespace GXpert.Content;

public interface IContentMediaRatingListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentMediaRatingListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentMediaRatingListHandler
{
    public ContentMediaRatingListHandler(IRequestContext context)
            : base(context)
    {
    }
}