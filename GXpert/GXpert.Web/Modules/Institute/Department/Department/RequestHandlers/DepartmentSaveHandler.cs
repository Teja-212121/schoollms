using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Institute.DepartmentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Institute.DepartmentRow;

namespace GXpert.Institute;

public interface IDepartmentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class DepartmentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDepartmentSaveHandler
{
    public DepartmentSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}