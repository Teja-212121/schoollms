using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Playlist.ModuleRow>;
using MyRow = GXpert.Playlist.ModuleRow;

namespace GXpert.Playlist;

public interface IModuleRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class ModuleRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IModuleRetrieveHandler
{
    public ModuleRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}