using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentLanguageRow>;
using MyRow = GXpert.Content.ContentLanguageRow;

namespace GXpert.Content;

public interface IContentLanguageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentLanguageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentLanguageRetrieveHandler
{
    public ContentLanguageRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}