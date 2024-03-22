using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Institute.InstituteStudentRow>;
using MyRow = GXpert.Institute.InstituteStudentRow;

namespace GXpert.Institute;

public interface IInstituteStudentListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteStudentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteStudentListHandler
{
    public InstituteStudentListHandler(IRequestContext context)
            : base(context)
    {
    }
}