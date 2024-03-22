using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.PreAcademicScoreRow>;
using MyRow = GXpert.Masters.PreAcademicScoreRow;

namespace GXpert.Masters;

public interface IPreAcademicScoreRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PreAcademicScoreRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPreAcademicScoreRetrieveHandler
{
    public PreAcademicScoreRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}