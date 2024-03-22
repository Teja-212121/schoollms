using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.UserAcademicRow>;
using MyRow = GXpert.Masters.UserAcademicRow;

namespace GXpert.Masters;

public interface IUserAcademicListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class UserAcademicListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserAcademicListHandler
{
    public UserAcademicListHandler(IRequestContext context)
            : base(context)
    {
    }
}