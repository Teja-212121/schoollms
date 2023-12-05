using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Masters.StateRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Masters.StateRow;

namespace GXpert.Masters;

public interface IStateSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class StateSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStateSaveHandler
{
    public StateSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}