using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Activation.ActivationRow>;
using MyRow = GXpert.Activation.ActivationRow;

namespace GXpert.Activation;

public interface IActivationListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ActivationListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IActivationListHandler
{
    public ActivationListHandler(IRequestContext context)
            : base(context)
    {
    }
}