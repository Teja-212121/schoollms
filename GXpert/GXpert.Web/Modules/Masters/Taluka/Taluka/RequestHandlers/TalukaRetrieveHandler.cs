using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.TalukaRow>;
using MyRow = GXpert.Masters.TalukaRow;

namespace GXpert.Masters;

public interface ITalukaRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class TalukaRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITalukaRetrieveHandler
{
    public TalukaRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}