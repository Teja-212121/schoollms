using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Activation.CouponCodeRow>;
using MyRow = GXpert.Activation.CouponCodeRow;

namespace GXpert.Activation;

public interface ICouponCodeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class CouponCodeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ICouponCodeRetrieveHandler
{
    public CouponCodeRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}