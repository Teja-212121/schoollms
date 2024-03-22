using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.PreAcademicRow>;
using MyRow = GXpert.Masters.PreAcademicRow;

namespace GXpert.Masters;

public interface IPreAcademicRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PreAcademicRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPreAcademicRetrieveHandler
{
    public PreAcademicRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}