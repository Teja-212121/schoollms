using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.AcademicYearRow>;
using MyRow = GXpert.Masters.AcademicYearRow;

namespace GXpert.Masters;

public interface IAcademicYearListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicYearListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicYearListHandler
{
    public AcademicYearListHandler(IRequestContext context)
            : base(context)
    {
    }
}