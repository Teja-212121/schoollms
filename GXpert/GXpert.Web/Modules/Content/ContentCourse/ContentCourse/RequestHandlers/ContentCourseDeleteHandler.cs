using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Content.ContentCourseRow;

namespace GXpert.Content;

public interface IContentCourseDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCourseDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IContentCourseDeleteHandler
{
    public ContentCourseDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}