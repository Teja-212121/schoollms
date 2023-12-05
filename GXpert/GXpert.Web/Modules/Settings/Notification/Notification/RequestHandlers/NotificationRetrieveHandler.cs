using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Settings.NotificationRow>;
using MyRow = GXpert.Settings.NotificationRow;

namespace GXpert.Settings;

public interface INotificationRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class NotificationRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, INotificationRetrieveHandler
{
    public NotificationRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}