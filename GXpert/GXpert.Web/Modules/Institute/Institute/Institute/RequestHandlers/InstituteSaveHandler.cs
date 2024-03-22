using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Institute.InstituteRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Institute.InstituteRow;

namespace GXpert.Institute;

public interface IInstituteSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteSaveHandler
{
    public InstituteSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}