using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Institute.InstituteRow;

namespace GXpert.Institute;

public interface IInstituteDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteDeleteHandler
{
    public InstituteDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}