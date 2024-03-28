using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentCategoryRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentCategoryRow;

namespace GXpert.Content;

public interface IContentCategorySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCategorySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentCategorySaveHandler
{
    public ContentCategorySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}