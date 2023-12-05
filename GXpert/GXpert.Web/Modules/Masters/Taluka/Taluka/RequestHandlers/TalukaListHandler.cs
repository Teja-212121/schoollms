using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Masters.TalukaRow>;
using MyRow = GXpert.Masters.TalukaRow;

namespace GXpert.Masters;

public interface ITalukaListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class TalukaListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITalukaListHandler
{
    public TalukaListHandler(IRequestContext context)
            : base(context)
    {
    }
}