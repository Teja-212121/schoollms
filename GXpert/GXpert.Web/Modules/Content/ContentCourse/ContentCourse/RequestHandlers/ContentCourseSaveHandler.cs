using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Content.ContentCourseRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Content.ContentCourseRow;

namespace GXpert.Content;

public interface IContentCourseSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ContentCourseSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IContentCourseSaveHandler
{
    public ContentCourseSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}