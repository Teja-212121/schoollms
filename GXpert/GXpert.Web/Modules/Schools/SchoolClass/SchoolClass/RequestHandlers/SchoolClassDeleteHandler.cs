using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Schools.SchoolClassRow;

namespace GXpert.Schools;

public interface ISchoolClassDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolClassDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolClassDeleteHandler
{
    public SchoolClassDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}