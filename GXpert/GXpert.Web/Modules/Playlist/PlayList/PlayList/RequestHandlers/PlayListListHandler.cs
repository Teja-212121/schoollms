using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Playlist.PlayListRow>;
using MyRow = GXpert.Playlist.PlayListRow;

namespace GXpert.Playlist;

public interface IPlayListListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListListHandler
{
    public PlayListListHandler(IRequestContext context)
            : base(context)
    {
    }
}