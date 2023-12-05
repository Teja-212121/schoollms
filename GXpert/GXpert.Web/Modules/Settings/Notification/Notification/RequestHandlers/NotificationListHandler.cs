using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Settings.NotificationRow>;
using MyRow = GXpert.Settings.NotificationRow;

namespace GXpert.Settings;

public interface INotificationListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class NotificationListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, INotificationListHandler
{
    public NotificationListHandler(IRequestContext context)
            : base(context)
    {
    }
}