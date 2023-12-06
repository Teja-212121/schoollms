using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Playlist.PlayListContentRow;

namespace GXpert.Playlist;

public interface IPlayListContentDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListContentDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListContentDeleteHandler
{
    public PlayListContentDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}