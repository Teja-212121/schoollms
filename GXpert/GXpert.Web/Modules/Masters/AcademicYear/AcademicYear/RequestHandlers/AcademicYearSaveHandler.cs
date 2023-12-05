using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.AcademicYearRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.AcademicYearRow;

namespace GXpert.Masters;

public interface IAcademicYearSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class AcademicYearSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAcademicYearSaveHandler
{
    public AcademicYearSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}