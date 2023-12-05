using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Activation.ActivationLogRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Activation.ActivationLogRow;

namespace GXpert.Activation;

public interface IActivationLogSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ActivationLogSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IActivationLogSaveHandler
{
    public ActivationLogSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}