using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Content.ContentCourseRow>;
using MyRow = GXpert.Content.ContentCourseRow;

namespace GXpert.Content;

public interface IContentCourseListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCourseListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IContentCourseListHandler
{
    public ContentCourseListHandler(IRequestContext context)
            : base(context)
    {
    }
}