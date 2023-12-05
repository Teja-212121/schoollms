using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Activation.CouponCodeRow>;
using MyRow = GXpert.Activation.CouponCodeRow;

namespace GXpert.Activation;

public interface ICouponCodeListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class CouponCodeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ICouponCodeListHandler
{
    public CouponCodeListHandler(IRequestContext context)
            : base(context)
    {
    }
}