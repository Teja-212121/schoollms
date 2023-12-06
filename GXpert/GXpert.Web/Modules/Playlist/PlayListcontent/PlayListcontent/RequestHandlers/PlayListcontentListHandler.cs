using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Playlist.PlayListContentRow>;
using MyRow = GXpert.Playlist.PlayListContentRow;

namespace GXpert.Playlist;

public interface IPlayListContentListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListContentListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListContentListHandler
{
    public PlayListContentListHandler(IRequestContext context)
            : base(context)
    {
    }
}