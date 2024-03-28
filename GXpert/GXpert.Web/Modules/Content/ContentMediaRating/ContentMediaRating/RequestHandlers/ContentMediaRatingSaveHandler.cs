using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentMediaRatingRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentMediaRatingRow;

namespace GXpert.Content;

public interface IContentMediaRatingSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentMediaRatingSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentMediaRatingSaveHandler
{
    public ContentMediaRatingSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}