using Serenity.Navigation;
using MyPages = GXpert.Settings.Pages;

[assembly: NavigationLink(int.MaxValue, "Settings/Smtp", typeof(MyPages.SmtpPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Storage", typeof(MyPages.StoragePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Sms", typeof(MyPages.SmsPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Settings/Notification", typeof(MyPages.NotificationPage), icon: null)]