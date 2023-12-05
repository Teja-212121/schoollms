using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Settings.StorageRow>;
using MyRow = GXpert.Settings.StorageRow;

namespace GXpert.Settings;

public interface IStorageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class StorageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStorageListHandler
{
    public StorageListHandler(IRequestContext context)
            : base(context)
    {
    }
}