using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Schools.SchoolClassRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Schools.SchoolClassRow;

namespace GXpert.Schools;

public interface ISchoolClassSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolClassSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolClassSaveHandler
{
    public SchoolClassSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}