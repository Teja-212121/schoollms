using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Settings.NotificationRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Settings.NotificationRow;

namespace GXpert.Settings;

public interface INotificationSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class NotificationSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, INotificationSaveHandler
{
    public NotificationSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}