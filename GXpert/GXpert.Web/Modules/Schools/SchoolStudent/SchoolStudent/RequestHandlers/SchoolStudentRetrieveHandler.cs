using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Schools.SchoolStudentRow>;
using MyRow = GXpert.Schools.SchoolStudentRow;

namespace GXpert.Schools;

public interface ISchoolStudentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolStudentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolStudentRetrieveHandler
{
    public SchoolStudentRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}