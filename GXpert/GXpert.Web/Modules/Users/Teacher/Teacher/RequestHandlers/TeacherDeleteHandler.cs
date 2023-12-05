using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Users.TeacherRow;

namespace GXpert.Users;

public interface ITeacherDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class TeacherDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITeacherDeleteHandler
{
    public TeacherDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}