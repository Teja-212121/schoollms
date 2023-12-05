using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Settings.NotificationRow;

namespace GXpert.Settings;

public interface INotificationDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class NotificationDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, INotificationDeleteHandler
{
    public NotificationDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}