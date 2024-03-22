using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Institute.InstituteTeacherRow;

namespace GXpert.Institute;

public interface IInstituteTeacherDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteTeacherDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteTeacherDeleteHandler
{
    public InstituteTeacherDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}