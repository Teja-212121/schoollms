using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Schools.SchoolTeacherRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Schools.SchoolTeacherRow;

namespace GXpert.Schools;

public interface ISchoolTeacherSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolTeacherSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolTeacherSaveHandler
{
    public SchoolTeacherSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}