using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Activation.PreDefinedKeyRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Activation.PreDefinedKeyRow;

namespace GXpert.Activation;

public interface IPreDefinedKeySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PreDefinedKeySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPreDefinedKeySaveHandler
{
    public PreDefinedKeySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}