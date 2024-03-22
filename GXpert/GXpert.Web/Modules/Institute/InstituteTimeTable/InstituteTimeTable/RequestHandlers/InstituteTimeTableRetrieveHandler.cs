using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Institute.InstituteTimeTableRow>;
using MyRow = GXpert.Institute.InstituteTimeTableRow;

namespace GXpert.Institute;

public interface IInstituteTimeTableRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteTimeTableRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteTimeTableRetrieveHandler
{
    public InstituteTimeTableRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}