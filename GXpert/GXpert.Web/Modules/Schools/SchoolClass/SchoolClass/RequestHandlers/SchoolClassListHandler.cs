using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Schools.SchoolClassRow>;
using MyRow = GXpert.Schools.SchoolClassRow;

namespace GXpert.Schools;

public interface ISchoolClassListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolClassListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolClassListHandler
{
    public SchoolClassListHandler(IRequestContext context)
            : base(context)
    {
    }
}