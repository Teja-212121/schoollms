using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Schools.SchoolTimeTableRow>;
using MyRow = GXpert.Schools.SchoolTimeTableRow;

namespace GXpert.Schools;

public interface ISchoolTimeTableListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolTimeTableListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolTimeTableListHandler
{
    public SchoolTimeTableListHandler(IRequestContext context)
            : base(context)
    {
    }
}