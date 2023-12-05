using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentBloomsIndexRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentBloomsIndexRow;

namespace GXpert.Content;

public interface IContentBloomsIndexSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentBloomsIndexSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentBloomsIndexSaveHandler
{
    public ContentBloomsIndexSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}