using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Activation.ActivationRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Activation.ActivationRow;

namespace GXpert.Activation;

public interface IActivationSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ActivationSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationSaveHandler
{
    public ActivationSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}