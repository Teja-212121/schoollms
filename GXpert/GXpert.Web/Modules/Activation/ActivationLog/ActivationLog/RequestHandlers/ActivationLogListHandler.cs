using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Activation.ActivationLogRow>;
using MyRow = GXpert.Activation.ActivationLogRow;

namespace GXpert.Activation;

public interface IActivationLogListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ActivationLogListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IActivationLogListHandler
{
    public ActivationLogListHandler(IRequestContext context)
            : base(context)
    {
    }
}