using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Users.StudentRow>;
using MyRow = GXpert.Users.StudentRow;

namespace GXpert.Users;

public interface IStudentListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class StudentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStudentListHandler
{
    public StudentListHandler(IRequestContext context)
            : base(context)
    {
    }
}