using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Schools.SchoolStudentRow>;
using MyRow = GXpert.Schools.SchoolStudentRow;

namespace GXpert.Schools;

public interface ISchoolStudentListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolStudentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolStudentListHandler
{
    public SchoolStudentListHandler(IRequestContext context)
            : base(context)
    {
    }
}