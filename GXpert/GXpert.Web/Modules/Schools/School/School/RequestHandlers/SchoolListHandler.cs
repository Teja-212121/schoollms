using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Schools.SchoolRow>;
using MyRow = GXpert.Schools.SchoolRow;

namespace GXpert.Schools;

public interface ISchoolListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolListHandler
{
    public SchoolListHandler(IRequestContext context)
            : base(context)
    {
    }
}