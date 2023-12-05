using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Playlist.PlayListRow;

namespace GXpert.Playlist;

public interface IPlayListDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListDeleteHandler
{
    public PlayListDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}