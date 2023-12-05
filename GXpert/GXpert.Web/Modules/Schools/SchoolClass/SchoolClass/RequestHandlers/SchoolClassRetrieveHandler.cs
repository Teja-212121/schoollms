using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Schools.SchoolClassRow>;
using MyRow = GXpert.Schools.SchoolClassRow;

namespace GXpert.Schools;

public interface ISchoolClassRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolClassRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolClassRetrieveHandler
{
    public SchoolClassRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}