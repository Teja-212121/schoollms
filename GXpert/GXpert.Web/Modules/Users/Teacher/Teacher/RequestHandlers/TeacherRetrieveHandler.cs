using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Users.TeacherRow>;
using MyRow = GXpert.Users.TeacherRow;

namespace GXpert.Users;

public interface ITeacherRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class TeacherRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITeacherRetrieveHandler
{
    public TeacherRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}