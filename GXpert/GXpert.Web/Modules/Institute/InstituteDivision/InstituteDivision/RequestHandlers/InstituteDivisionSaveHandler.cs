using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Institute.InstituteDivisionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Institute.InstituteDivisionRow;

namespace GXpert.Institute;

public interface IInstituteDivisionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteDivisionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteDivisionSaveHandler
{
    public InstituteDivisionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}