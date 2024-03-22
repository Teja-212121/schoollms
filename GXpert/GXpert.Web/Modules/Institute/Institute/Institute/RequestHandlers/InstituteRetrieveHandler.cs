using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Institute.InstituteRow>;
using MyRow = GXpert.Institute.InstituteRow;

namespace GXpert.Institute;

public interface IInstituteRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteRetrieveHandler
{
    public InstituteRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}