using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Schools.SchoolRow>;
using MyRow = GXpert.Schools.SchoolRow;

namespace GXpert.Schools;

public interface ISchoolRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolRetrieveHandler
{
    public SchoolRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}