using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.AcademicSubjectPerformanceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.AcademicSubjectPerformanceRow;

namespace GXpert.Masters;

public interface IAcademicSubjectPerformanceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicSubjectPerformanceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicSubjectPerformanceSaveHandler
{
    public AcademicSubjectPerformanceSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}