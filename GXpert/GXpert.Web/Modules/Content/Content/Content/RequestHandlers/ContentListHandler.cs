using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentRow>;
using MyRow = GXpert.Content.ContentRow;

namespace GXpert.Content;

public interface IContentListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentListHandler
{
    public ContentListHandler(IRequestContext context)
            : base(context)
    {
    }
}