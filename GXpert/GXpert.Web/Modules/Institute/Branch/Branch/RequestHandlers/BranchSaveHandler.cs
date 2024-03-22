using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Institute.BranchRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Institute.BranchRow;

namespace GXpert.Institute;

public interface IBranchSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class BranchSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IBranchSaveHandler
{
    public BranchSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}