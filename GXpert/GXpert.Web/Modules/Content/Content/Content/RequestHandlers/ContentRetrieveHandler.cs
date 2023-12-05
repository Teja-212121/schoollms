using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentRow>;
using MyRow = GXpert.Content.ContentRow;

namespace GXpert.Content;

public interface IContentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentRetrieveHandler
{
    public ContentRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}