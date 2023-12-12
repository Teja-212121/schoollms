using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Activation.PreDefinedKeyRow>;
using MyRow = GXpert.Activation.PreDefinedKeyRow;

namespace GXpert.Activation;

public interface IPreDefinedKeyListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PreDefinedKeyListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPreDefinedKeyListHandler
{
    public PreDefinedKeyListHandler(IRequestContext context)
            : base(context)
    {
    }
}