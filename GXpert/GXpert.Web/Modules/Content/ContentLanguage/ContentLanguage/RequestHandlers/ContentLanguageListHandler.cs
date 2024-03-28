using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentLanguageRow>;
using MyRow = GXpert.Content.ContentLanguageRow;

namespace GXpert.Content;

public interface IContentLanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentLanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentLanguageListHandler
{
    public ContentLanguageListHandler(IRequestContext context)
            : base(context)
    {
    }
}