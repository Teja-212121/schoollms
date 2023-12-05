using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Playlist.PlayListcontentRow;

namespace GXpert.Playlist;

public interface IPlayListcontentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListcontentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListcontentDeleteHandler
{
    public PlayListcontentDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}