using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Activation.SerialKeyRow>;
using MyRow = GXpert.Activation.SerialKeyRow;

namespace GXpert.Activation;

public interface ISerialKeyRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class SerialKeyRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ISerialKeyRetrieveHandler
{
    public SerialKeyRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}