using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Settings.StorageRow>;
using MyRow = GXpert.Settings.StorageRow;

namespace GXpert.Settings;

public interface IStorageRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class StorageRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStorageRetrieveHandler
{
    public StorageRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}