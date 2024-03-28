using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentRatingRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentRatingRow;

namespace GXpert.Content;

public interface IContentRatingSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentRatingSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentRatingSaveHandler
{
    public ContentRatingSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}