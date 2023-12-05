using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.AcademicYearRow;

namespace GXpert.Masters;

public interface IAcademicYearDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicYearDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicYearDeleteHandler
{
    public AcademicYearDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}