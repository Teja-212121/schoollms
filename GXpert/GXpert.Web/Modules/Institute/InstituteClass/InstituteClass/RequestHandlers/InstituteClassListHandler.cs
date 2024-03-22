using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Institute.InstituteClassRow>;
using MyRow = GXpert.Institute.InstituteClassRow;

namespace GXpert.Institute;

public interface IInstituteClassListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteClassListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteClassListHandler
{
    public InstituteClassListHandler(IRequestContext context)
            : base(context)
    {
    }
}