using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Institute.InstituteTeacherRow>;
using MyRow = GXpert.Institute.InstituteTeacherRow;

namespace GXpert.Institute;

public interface IInstituteTeacherRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteTeacherRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteTeacherRetrieveHandler
{
    public InstituteTeacherRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}