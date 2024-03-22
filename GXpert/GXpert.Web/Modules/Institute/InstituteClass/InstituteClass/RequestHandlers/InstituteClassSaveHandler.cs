using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Institute.InstituteClassRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Institute.InstituteClassRow;

namespace GXpert.Institute;

public interface IInstituteClassSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteClassSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteClassSaveHandler
{
    public InstituteClassSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}