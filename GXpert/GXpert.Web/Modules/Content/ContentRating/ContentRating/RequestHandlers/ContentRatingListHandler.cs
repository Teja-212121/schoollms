using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentRatingRow>;
using MyRow = GXpert.Content.ContentRatingRow;

namespace GXpert.Content;

public interface IContentRatingListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentRatingListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentRatingListHandler
{
    public ContentRatingListHandler(IRequestContext context)
            : base(context)
    {
    }
}