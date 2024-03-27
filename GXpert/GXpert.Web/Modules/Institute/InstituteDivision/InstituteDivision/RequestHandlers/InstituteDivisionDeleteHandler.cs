using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Institute.InstituteDivisionRow;

namespace GXpert.Institute;

public interface IInstituteDivisionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteDivisionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteDivisionDeleteHandler
{
    public InstituteDivisionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}