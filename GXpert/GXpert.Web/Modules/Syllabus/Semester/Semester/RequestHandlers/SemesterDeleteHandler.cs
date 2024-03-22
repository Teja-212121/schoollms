using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Syllabus.SemesterRow;

namespace GXpert.Syllabus;

public interface ISemesterDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SemesterDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISemesterDeleteHandler
{
    public SemesterDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}