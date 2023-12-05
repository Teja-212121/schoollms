using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Playlist.PlayListcontentRow>;
using MyRow = GXpert.Playlist.PlayListcontentRow;

namespace GXpert.Playlist;

public interface IPlayListcontentListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListcontentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListcontentListHandler
{
    public PlayListcontentListHandler(IRequestContext context)
            : base(context)
    {
    }
}