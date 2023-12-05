using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Users.TeacherRow>;
using MyRow = GXpert.Users.TeacherRow;

namespace GXpert.Users;

public interface ITeacherListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class TeacherListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITeacherListHandler
{
    public TeacherListHandler(IRequestContext context)
            : base(context)
    {
    }
}