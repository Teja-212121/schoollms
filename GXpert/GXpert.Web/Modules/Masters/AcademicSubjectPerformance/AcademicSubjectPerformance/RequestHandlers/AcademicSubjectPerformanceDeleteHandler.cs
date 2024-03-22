using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.AcademicSubjectPerformanceRow;

namespace GXpert.Masters;

public interface IAcademicSubjectPerformanceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicSubjectPerformanceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicSubjectPerformanceDeleteHandler
{
    public AcademicSubjectPerformanceDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}