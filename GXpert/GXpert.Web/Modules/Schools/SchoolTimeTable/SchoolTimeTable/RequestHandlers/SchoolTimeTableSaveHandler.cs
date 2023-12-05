using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Schools.SchoolTimeTableRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Schools.SchoolTimeTableRow;

namespace GXpert.Schools;

public interface ISchoolTimeTableSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SchoolTimeTableSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISchoolTimeTableSaveHandler
{
    public SchoolTimeTableSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}