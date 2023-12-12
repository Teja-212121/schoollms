using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Activation.PreDefinedKeyRow>;
using MyRow = GXpert.Activation.PreDefinedKeyRow;

namespace GXpert.Activation;

public interface IPreDefinedKeyRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PreDefinedKeyRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPreDefinedKeyRetrieveHandler
{
    public PreDefinedKeyRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}