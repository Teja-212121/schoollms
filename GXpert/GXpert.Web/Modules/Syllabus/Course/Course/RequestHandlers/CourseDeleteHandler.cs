using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Syllabus.CourseRow;

namespace GXpert.Syllabus;

public interface ICourseDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CourseDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICourseDeleteHandler
{
    public CourseDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}