using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentBloomsIndexRow;

namespace GXpert.Content;

public interface IContentBloomsIndexDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentBloomsIndexDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentBloomsIndexDeleteHandler
{
    public ContentBloomsIndexDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}