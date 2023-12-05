using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Activation.SerialKeyRow>;
using MyRow = GXpert.Activation.SerialKeyRow;

namespace GXpert.Activation;

public interface ISerialKeyListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class SerialKeyListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ISerialKeyListHandler
{
    public SerialKeyListHandler(IRequestContext context)
            : base(context)
    {
    }
}