using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Playlist.PlayListContentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Playlist.PlayListContentRow;

namespace GXpert.Playlist;

public interface IPlayListContentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListContentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListContentSaveHandler
{
    public PlayListContentSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}