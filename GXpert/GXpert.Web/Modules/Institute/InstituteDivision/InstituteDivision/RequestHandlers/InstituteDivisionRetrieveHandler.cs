using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Institute.InstituteDivisionRow>;
using MyRow = GXpert.Institute.InstituteDivisionRow;

namespace GXpert.Institute;

public interface IInstituteDivisionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteDivisionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteDivisionRetrieveHandler
{
    public InstituteDivisionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}