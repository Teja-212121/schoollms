using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Schools.SchoolTeacherRow>;
using MyRow = GXpert.Schools.SchoolTeacherRow;

namespace GXpert.Schools;

public interface ISchoolTeacherListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolTeacherListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolTeacherListHandler
{
    public SchoolTeacherListHandler(IRequestContext context)
            : base(context)
    {
    }
}