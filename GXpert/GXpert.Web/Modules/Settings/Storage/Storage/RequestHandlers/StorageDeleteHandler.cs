using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Settings.StorageRow;

namespace GXpert.Settings;

public interface IStorageDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class StorageDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IStorageDeleteHandler
{
    public StorageDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}