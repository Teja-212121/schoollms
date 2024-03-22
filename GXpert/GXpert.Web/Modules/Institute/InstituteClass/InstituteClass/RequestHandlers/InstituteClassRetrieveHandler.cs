using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Institute.InstituteClassRow>;
using MyRow = GXpert.Institute.InstituteClassRow;

namespace GXpert.Institute;

public interface IInstituteClassRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteClassRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteClassRetrieveHandler
{
    public InstituteClassRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}