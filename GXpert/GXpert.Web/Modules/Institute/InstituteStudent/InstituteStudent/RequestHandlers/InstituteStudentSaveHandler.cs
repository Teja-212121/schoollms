using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Institute.InstituteStudentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Institute.InstituteStudentRow;

namespace GXpert.Institute;

public interface IInstituteStudentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteStudentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteStudentSaveHandler
{
    public InstituteStudentSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}