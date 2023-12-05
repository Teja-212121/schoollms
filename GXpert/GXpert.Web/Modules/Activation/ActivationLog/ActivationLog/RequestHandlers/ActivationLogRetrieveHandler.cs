using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Activation.ActivationLogRow>;
using MyRow = GXpert.Activation.ActivationLogRow;

namespace GXpert.Activation;

public interface IActivationLogRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ActivationLogRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationLogRetrieveHandler
{
    public ActivationLogRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}