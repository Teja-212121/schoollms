using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Playlist.ModuleRow>;
using MyRow = GXpert.Playlist.ModuleRow;

namespace GXpert.Playlist;

public interface IModuleListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class ModuleListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IModuleListHandler
{
    public ModuleListHandler(IRequestContext context)
            : base(context)
    {
    }
}