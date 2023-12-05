using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Playlist.ModuleRow;

namespace GXpert.Playlist;

public interface IModuleDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class ModuleDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IModuleDeleteHandler
{
    public ModuleDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}