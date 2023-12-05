using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Activation.CouponCodeRow;

namespace GXpert.Activation;

public interface ICouponCodeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class CouponCodeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ICouponCodeDeleteHandler
{
    public CouponCodeDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}