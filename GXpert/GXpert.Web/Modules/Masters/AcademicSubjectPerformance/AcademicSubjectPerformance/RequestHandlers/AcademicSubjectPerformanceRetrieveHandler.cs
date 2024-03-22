using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.AcademicSubjectPerformanceRow>;
using MyRow = GXpert.Masters.AcademicSubjectPerformanceRow;

namespace GXpert.Masters;

public interface IAcademicSubjectPerformanceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicSubjectPerformanceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicSubjectPerformanceRetrieveHandler
{
    public AcademicSubjectPerformanceRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}