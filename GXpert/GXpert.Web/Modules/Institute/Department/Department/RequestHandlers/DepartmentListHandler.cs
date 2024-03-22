using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Institute.DepartmentRow>;
using MyRow = GXpert.Institute.DepartmentRow;

namespace GXpert.Institute;

public interface IDepartmentListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class DepartmentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentListHandler
{
    public DepartmentListHandler(IRequestContext context)
            : base(context)
    {
    }
}