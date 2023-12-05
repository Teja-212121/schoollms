using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Schools.SchoolTeacherRow;

namespace GXpert.Schools;

public interface ISchoolTeacherDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolTeacherDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolTeacherDeleteHandler
{
    public SchoolTeacherDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}