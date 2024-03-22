using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.PreAcademicScoreRow>;
using MyRow = GXpert.Masters.PreAcademicScoreRow;

namespace GXpert.Masters;

public interface IPreAcademicScoreListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PreAcademicScoreListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPreAcademicScoreListHandler
{
    public PreAcademicScoreListHandler(IRequestContext context)
            : base(context)
    {
    }
}