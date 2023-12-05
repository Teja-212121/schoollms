using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Activation.ActivationRow>;
using MyRow = GXpert.Activation.ActivationRow;

namespace GXpert.Activation;

public interface IActivationRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ActivationRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationRetrieveHandler
{
    public ActivationRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}