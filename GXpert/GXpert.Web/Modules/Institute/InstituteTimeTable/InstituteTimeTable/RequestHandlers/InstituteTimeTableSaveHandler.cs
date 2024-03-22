using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Institute.InstituteTimeTableRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Institute.InstituteTimeTableRow;

namespace GXpert.Institute;

public interface IInstituteTimeTableSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteTimeTableSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteTimeTableSaveHandler
{
    public InstituteTimeTableSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}