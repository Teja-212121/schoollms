using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.AcademicSubjectPerformanceRow>;
using MyRow = GXpert.Masters.AcademicSubjectPerformanceRow;

namespace GXpert.Masters;

public interface IAcademicSubjectPerformanceListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicSubjectPerformanceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicSubjectPerformanceListHandler
{
    public AcademicSubjectPerformanceListHandler(IRequestContext context)
            : base(context)
    {
    }
}