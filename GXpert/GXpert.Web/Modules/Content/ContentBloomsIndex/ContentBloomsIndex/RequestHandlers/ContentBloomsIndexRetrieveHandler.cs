using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentBloomsIndexRow>;
using MyRow = GXpert.Content.ContentBloomsIndexRow;

namespace GXpert.Content;

public interface IContentBloomsIndexRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentBloomsIndexRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentBloomsIndexRetrieveHandler
{
    public ContentBloomsIndexRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}