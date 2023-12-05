using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.StateRow;

namespace GXpert.Masters;

public interface IStateDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class StateDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IStateDeleteHandler
{
    public StateDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}