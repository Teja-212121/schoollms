using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Institute.InstituteStudentRow;

namespace GXpert.Institute;

public interface IInstituteStudentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class InstituteStudentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IInstituteStudentDeleteHandler
{
    public InstituteStudentDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}