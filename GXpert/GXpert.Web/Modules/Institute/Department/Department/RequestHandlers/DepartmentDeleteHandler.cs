using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Institute.DepartmentRow;

namespace GXpert.Institute;

public interface IDepartmentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class DepartmentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentDeleteHandler
{
    public DepartmentDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}