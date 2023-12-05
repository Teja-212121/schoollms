using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Users.TeacherRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Users.TeacherRow;

namespace GXpert.Users;

public interface ITeacherSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class TeacherSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITeacherSaveHandler
{
    public TeacherSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}