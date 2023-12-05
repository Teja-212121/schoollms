using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Playlist.PlayListRow>;
using MyRow = GXpert.Playlist.PlayListRow;

namespace GXpert.Playlist;

public interface IPlayListRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListRetrieveHandler
{
    public PlayListRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}