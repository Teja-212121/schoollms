using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Activation.SerialKeyRow;

namespace GXpert.Activation;

public interface ISerialKeyDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class SerialKeyDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ISerialKeyDeleteHandler
{
    public SerialKeyDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}