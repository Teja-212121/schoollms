using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.AcademicPerformanceRow>;
using MyRow = GXpert.Masters.AcademicPerformanceRow;

namespace GXpert.Masters;

public interface IAcademicPerformanceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicPerformanceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicPerformanceRetrieveHandler
{
    public AcademicPerformanceRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}