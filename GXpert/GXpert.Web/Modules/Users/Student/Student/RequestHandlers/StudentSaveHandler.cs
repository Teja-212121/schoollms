using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Users.StudentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Users.StudentRow;

namespace GXpert.Users;

public interface IStudentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class StudentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStudentSaveHandler
{
    public StudentSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}