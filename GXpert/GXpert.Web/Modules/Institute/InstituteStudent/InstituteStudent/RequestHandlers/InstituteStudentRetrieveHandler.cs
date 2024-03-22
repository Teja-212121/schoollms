using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Institute.InstituteStudentRow>;
using MyRow = GXpert.Institute.InstituteStudentRow;

namespace GXpert.Institute;

public interface IInstituteStudentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteStudentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteStudentRetrieveHandler
{
    public InstituteStudentRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}