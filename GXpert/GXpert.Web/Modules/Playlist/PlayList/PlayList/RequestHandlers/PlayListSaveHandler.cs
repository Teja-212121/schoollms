using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Playlist.PlayListRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Playlist.PlayListRow;

namespace GXpert.Playlist;

public interface IPlayListSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListSaveHandler
{
    public PlayListSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}