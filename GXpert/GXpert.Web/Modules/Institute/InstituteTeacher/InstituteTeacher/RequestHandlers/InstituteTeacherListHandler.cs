using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Institute.InstituteTeacherRow>;
using MyRow = GXpert.Institute.InstituteTeacherRow;

namespace GXpert.Institute;

public interface IInstituteTeacherListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteTeacherListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteTeacherListHandler
{
    public InstituteTeacherListHandler(IRequestContext context)
            : base(context)
    {
    }
}