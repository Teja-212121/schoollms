using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Activation.ActivationLogRow;

namespace GXpert.Activation;

public interface IActivationLogDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ActivationLogDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IActivationLogDeleteHandler
{
    public ActivationLogDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}