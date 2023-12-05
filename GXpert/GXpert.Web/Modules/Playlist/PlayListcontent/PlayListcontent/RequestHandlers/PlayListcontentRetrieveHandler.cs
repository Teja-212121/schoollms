using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Playlist.PlayListcontentRow>;
using MyRow = GXpert.Playlist.PlayListcontentRow;

namespace GXpert.Playlist;

public interface IPlayListcontentRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class PlayListcontentRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IPlayListcontentRetrieveHandler
{
    public PlayListcontentRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}