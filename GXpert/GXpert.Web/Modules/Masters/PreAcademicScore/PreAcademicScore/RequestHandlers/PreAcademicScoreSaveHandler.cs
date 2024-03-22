using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.PreAcademicScoreRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.PreAcademicScoreRow;

namespace GXpert.Masters;

public interface IPreAcademicScoreSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PreAcademicScoreSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPreAcademicScoreSaveHandler
{
    public PreAcademicScoreSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}