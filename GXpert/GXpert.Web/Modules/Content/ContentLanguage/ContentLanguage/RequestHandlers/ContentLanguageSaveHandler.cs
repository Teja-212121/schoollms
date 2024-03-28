using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentLanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentLanguageRow;

namespace GXpert.Content;

public interface IContentLanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentLanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentLanguageSaveHandler
{
    public ContentLanguageSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}