using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Masters.StateRow>;
using MyRow = GXpert.Masters.StateRow;

namespace GXpert.Masters;

public interface IStateRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class StateRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStateRetrieveHandler
{
    public StateRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}