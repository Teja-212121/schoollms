using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentTopicRow>;
using MyRow = GXpert.Content.ContentTopicRow;

namespace GXpert.Content;

public interface IContentTopicListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentTopicListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentTopicListHandler
{
    public ContentTopicListHandler(IRequestContext context)
            : base(context)
    {
    }
}