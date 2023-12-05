using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentRow;

namespace GXpert.Content;

public interface IContentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentDeleteHandler
{
    public ContentDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}