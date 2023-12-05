using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Schools.SchoolTimeTableRow>;
using MyRow = GXpert.Schools.SchoolTimeTableRow;

namespace GXpert.Schools;

public interface ISchoolTimeTableRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolTimeTableRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolTimeTableRetrieveHandler
{
    public SchoolTimeTableRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}