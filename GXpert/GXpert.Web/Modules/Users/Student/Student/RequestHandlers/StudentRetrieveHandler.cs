using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Users.StudentRow>;
using MyRow = GXpert.Users.StudentRow;

namespace GXpert.Users;

public interface IStudentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class StudentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStudentRetrieveHandler
{
    public StudentRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}