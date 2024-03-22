using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.AcademicPerformanceRow>;
using MyRow = GXpert.Masters.AcademicPerformanceRow;

namespace GXpert.Masters;

public interface IAcademicPerformanceListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicPerformanceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicPerformanceListHandler
{
    public AcademicPerformanceListHandler(IRequestContext context)
            : base(context)
    {
    }
}