using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Syllabus.CourseRow>;
using MyRow = GXpert.Syllabus.CourseRow;

namespace GXpert.Syllabus;

public interface ICourseListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CourseListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICourseListHandler
{
    public CourseListHandler(IRequestContext context)
            : base(context)
    {
    }
}