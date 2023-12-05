using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Masters.DistrictRow;

namespace GXpert.Masters;

public interface IDistrictDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class DistrictDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDistrictDeleteHandler
{
    public DistrictDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}