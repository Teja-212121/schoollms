using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.AcademicYearRow>;
using MyRow = GXpert.Masters.AcademicYearRow;

namespace GXpert.Masters;

public interface IAcademicYearRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicYearRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicYearRetrieveHandler
{
    public AcademicYearRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}