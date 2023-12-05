using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.StateRow>;
using MyRow = GXpert.Masters.StateRow;

namespace GXpert.Masters;

public interface IStateListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class StateListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStateListHandler
{
    public StateListHandler(IRequestContext context)
            : base(context)
    {
    }
}