using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Syllabus.CourseRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Syllabus.CourseRow;

namespace GXpert.Syllabus;

public interface ICourseSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CourseSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICourseSaveHandler
{
    public CourseSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}