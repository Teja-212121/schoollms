using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Schools.SchoolTeacherRow>;
using MyRow = GXpert.Schools.SchoolTeacherRow;

namespace GXpert.Schools;

public interface ISchoolTeacherRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolTeacherRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolTeacherRetrieveHandler
{
    public SchoolTeacherRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}