using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Syllabus.CourseRow>;
using MyRow = GXpert.Syllabus.CourseRow;

namespace GXpert.Syllabus;

public interface ICourseRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CourseRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICourseRetrieveHandler
{
    public CourseRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}