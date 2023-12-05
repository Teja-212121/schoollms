using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentTopicRow;

namespace GXpert.Content;

public interface IContentTopicDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentTopicDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentTopicDeleteHandler
{
    public ContentTopicDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}