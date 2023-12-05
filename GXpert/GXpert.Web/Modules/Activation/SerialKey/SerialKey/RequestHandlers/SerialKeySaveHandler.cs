using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Activation.SerialKeyRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Activation.SerialKeyRow;

namespace GXpert.Activation;

public interface ISerialKeySaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class SerialKeySaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ISerialKeySaveHandler
{
    public SerialKeySaveHandler(IRequestContext context)
            : base(context)
    {
    }
}