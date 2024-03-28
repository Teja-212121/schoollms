using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Content.ContentCourseRow>;
using MyRow = GXpert.Content.ContentCourseRow;

namespace GXpert.Content;

public interface IContentCourseRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCourseRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IContentCourseRetrieveHandler
{
    public ContentCourseRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}