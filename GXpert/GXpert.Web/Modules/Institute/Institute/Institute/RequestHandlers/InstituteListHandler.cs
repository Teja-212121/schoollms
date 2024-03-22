using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Institute.InstituteRow>;
using MyRow = GXpert.Institute.InstituteRow;

namespace GXpert.Institute;

public interface IInstituteListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteListHandler
{
    public InstituteListHandler(IRequestContext context)
            : base(context)
    {
    }
}