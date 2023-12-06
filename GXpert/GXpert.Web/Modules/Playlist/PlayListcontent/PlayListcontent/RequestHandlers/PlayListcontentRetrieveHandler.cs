using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Playlist.PlayListContentRow>;
using MyRow = GXpert.Playlist.PlayListContentRow;

namespace GXpert.Playlist;

public interface IPlayListContentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListContentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListContentRetrieveHandler
{
    public PlayListContentRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}