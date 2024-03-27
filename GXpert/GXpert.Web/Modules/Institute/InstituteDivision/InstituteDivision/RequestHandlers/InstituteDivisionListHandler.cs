using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Institute.InstituteDivisionRow>;
using MyRow = GXpert.Institute.InstituteDivisionRow;

namespace GXpert.Institute;

public interface IInstituteDivisionListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteDivisionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteDivisionListHandler
{
    public InstituteDivisionListHandler(IRequestContext context)
            : base(context)
    {
    }
}