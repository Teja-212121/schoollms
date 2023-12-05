using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Playlist.ModuleRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Playlist.ModuleRow;

namespace GXpert.Playlist;

public interface IModuleSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class ModuleSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IModuleSaveHandler
{
    public ModuleSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}