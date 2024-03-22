using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.PreAcademicRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.PreAcademicRow;

namespace GXpert.Masters;

public interface IPreAcademicSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PreAcademicSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPreAcademicSaveHandler
{
    public PreAcademicSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}