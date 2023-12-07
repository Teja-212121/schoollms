using Serenity.Navigation;
using MyPages = GXpert.Settings.Pages;

[assembly: NavigationMenu(14000, "Settings", icon: "fa fa-cogs")]
[assembly: NavigationLink(14001, "Settings/Smtp", typeof(MyPages.SmtpPage), icon: "fa-circle-o")]
[assembly: NavigationLink(14002, "Settings/Storage", typeof(MyPages.StoragePage), icon: "fa-circle-o")]
[assembly: NavigationLink(14003, "Settings/Sms", typeof(MyPages.SmsPage), icon: "fa-circle-o")]
[assembly: NavigationLink(14004, "Settings/Notification", typeof(MyPages.NotificationPage), icon: "fa-circle-o")]