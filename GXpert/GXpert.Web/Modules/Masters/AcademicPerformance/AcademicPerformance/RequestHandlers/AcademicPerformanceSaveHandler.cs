using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.AcademicPerformanceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.AcademicPerformanceRow;

namespace GXpert.Masters;

public interface IAcademicPerformanceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicPerformanceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicPerformanceSaveHandler
{
    public AcademicPerformanceSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}