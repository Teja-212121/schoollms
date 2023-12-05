using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Activation.CouponCodeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Activation.CouponCodeRow;

namespace GXpert.Activation;

public interface ICouponCodeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class CouponCodeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ICouponCodeSaveHandler
{
    public CouponCodeSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}