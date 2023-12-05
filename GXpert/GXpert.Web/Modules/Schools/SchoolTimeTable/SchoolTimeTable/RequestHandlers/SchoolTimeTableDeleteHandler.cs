using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Schools.SchoolTimeTableRow;

namespace GXpert.Schools;

public interface ISchoolTimeTableDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolTimeTableDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolTimeTableDeleteHandler
{
    public SchoolTimeTableDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}