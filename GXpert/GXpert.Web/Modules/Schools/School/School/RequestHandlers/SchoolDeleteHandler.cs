using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Schools.SchoolRow;

namespace GXpert.Schools;

public interface ISchoolDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolDeleteHandler
{
    public SchoolDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}