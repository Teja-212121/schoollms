using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Institute.InstituteTimeTableRow>;
using MyRow = GXpert.Institute.InstituteTimeTableRow;

namespace GXpert.Institute;

public interface IInstituteTimeTableListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteTimeTableListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteTimeTableListHandler
{
    public InstituteTimeTableListHandler(IRequestContext context)
            : base(context)
    {
    }
}