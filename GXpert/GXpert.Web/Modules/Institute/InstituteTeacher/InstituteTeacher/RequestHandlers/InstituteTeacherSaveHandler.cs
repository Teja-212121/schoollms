using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Institute.InstituteTeacherRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Institute.InstituteTeacherRow;

namespace GXpert.Institute;

public interface IInstituteTeacherSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteTeacherSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteTeacherSaveHandler
{
    public InstituteTeacherSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}