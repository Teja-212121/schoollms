using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Settings.StorageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Settings.StorageRow;

namespace GXpert.Settings;

public interface IStorageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class StorageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStorageSaveHandler
{
    public StorageSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}