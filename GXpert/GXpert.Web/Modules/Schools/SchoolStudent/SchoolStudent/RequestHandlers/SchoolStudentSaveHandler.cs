using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Schools.SchoolStudentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Schools.SchoolStudentRow;

namespace GXpert.Schools;

public interface ISchoolStudentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolStudentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolStudentSaveHandler
{
    public SchoolStudentSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}