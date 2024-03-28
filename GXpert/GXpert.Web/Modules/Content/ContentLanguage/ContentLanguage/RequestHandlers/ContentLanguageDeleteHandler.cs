using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentLanguageRow;

namespace GXpert.Content;

public interface IContentLanguageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentLanguageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentLanguageDeleteHandler
{
    public ContentLanguageDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}