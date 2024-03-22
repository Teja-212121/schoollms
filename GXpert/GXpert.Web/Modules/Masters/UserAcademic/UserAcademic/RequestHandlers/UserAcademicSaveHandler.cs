using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.UserAcademicRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.UserAcademicRow;

namespace GXpert.Masters;

public interface IUserAcademicSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class UserAcademicSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IUserAcademicSaveHandler
{
    public UserAcademicSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}