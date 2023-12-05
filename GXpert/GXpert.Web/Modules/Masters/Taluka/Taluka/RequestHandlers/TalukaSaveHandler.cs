using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.TalukaRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.TalukaRow;

namespace GXpert.Masters;

public interface ITalukaSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class TalukaSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITalukaSaveHandler
{
    public TalukaSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}