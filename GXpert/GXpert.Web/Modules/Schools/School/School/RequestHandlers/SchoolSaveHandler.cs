using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Schools.SchoolRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Schools.SchoolRow;

namespace GXpert.Schools;

public interface ISchoolSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolSaveHandler
{
    public SchoolSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}