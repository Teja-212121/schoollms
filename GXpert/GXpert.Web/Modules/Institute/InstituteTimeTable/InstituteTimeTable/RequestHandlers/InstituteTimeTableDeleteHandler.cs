using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Institute.InstituteTimeTableRow;

namespace GXpert.Institute;

public interface IInstituteTimeTableDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteTimeTableDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteTimeTableDeleteHandler
{
    public InstituteTimeTableDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}