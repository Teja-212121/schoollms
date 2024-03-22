using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.PreAcademicScoreRow;

namespace GXpert.Masters;

public interface IPreAcademicScoreDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PreAcademicScoreDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPreAcademicScoreDeleteHandler
{
    public PreAcademicScoreDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}