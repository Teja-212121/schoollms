using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentBloomsIndexRow>;
using MyRow = GXpert.Content.ContentBloomsIndexRow;

namespace GXpert.Content;

public interface IContentBloomsIndexListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentBloomsIndexListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentBloomsIndexListHandler
{
    public ContentBloomsIndexListHandler(IRequestContext context)
            : base(context)
    {
    }
}