using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Playlist.PlayListcontentRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Playlist.PlayListcontentRow;

namespace GXpert.Playlist;

public interface IPlayListcontentSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListcontentSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListcontentSaveHandler
{
    public PlayListcontentSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}