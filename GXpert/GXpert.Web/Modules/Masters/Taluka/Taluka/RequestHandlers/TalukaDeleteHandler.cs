using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.TalukaRow;

namespace GXpert.Masters;

public interface ITalukaDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class TalukaDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITalukaDeleteHandler
{
    public TalukaDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}