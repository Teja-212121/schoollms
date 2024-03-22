using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.UserAcademicRow>;
using MyRow = GXpert.Masters.UserAcademicRow;

namespace GXpert.Masters;

public interface IUserAcademicRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class UserAcademicRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IUserAcademicRetrieveHandler
{
    public UserAcademicRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}