using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.UserAcademicRow;

namespace GXpert.Masters;

public interface IUserAcademicDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class UserAcademicDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IUserAcademicDeleteHandler
{
    public UserAcademicDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}