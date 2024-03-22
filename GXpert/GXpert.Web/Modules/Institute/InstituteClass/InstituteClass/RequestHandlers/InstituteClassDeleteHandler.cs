using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Institute.InstituteClassRow;

namespace GXpert.Institute;

public interface IInstituteClassDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteClassDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteClassDeleteHandler
{
    public InstituteClassDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}