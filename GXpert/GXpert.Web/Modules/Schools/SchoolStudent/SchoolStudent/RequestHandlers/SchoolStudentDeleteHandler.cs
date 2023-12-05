using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Schools.SchoolStudentRow;

namespace GXpert.Schools;

public interface ISchoolStudentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolStudentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolStudentDeleteHandler
{
    public SchoolStudentDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}