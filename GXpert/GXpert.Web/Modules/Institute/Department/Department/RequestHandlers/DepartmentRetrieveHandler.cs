using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Institute.DepartmentRow>;
using MyRow = GXpert.Institute.DepartmentRow;

namespace GXpert.Institute;

public interface IDepartmentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class DepartmentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentRetrieveHandler
{
    public DepartmentRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}