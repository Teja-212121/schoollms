using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.AcademicPerformanceRow;

namespace GXpert.Masters;

public interface IAcademicPerformanceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicPerformanceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicPerformanceDeleteHandler
{
    public AcademicPerformanceDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}