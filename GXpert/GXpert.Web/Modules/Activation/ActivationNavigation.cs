using Serenity.Navigation;
using MyPages = GXpert.Activation.Pages;

[assembly: NavigationMenu(10000, "Activation", icon: "fa fa-check")]
[assembly: NavigationLink(10001, "Activation/Pre Defined Key", typeof(MyPages.PreDefinedKeyPage), icon: "fa-circle-o")]
[assembly: NavigationLink(10002, "Activation/Coupon Code", typeof(MyPages.CouponCodePage), icon: "fa-circle-o")]
[assembly: NavigationLink(10003, "Activation/Serial Key", typeof(MyPages.SerialKeyPage), icon: "fa-circle-o")]
[assembly: NavigationLink(10004, "Activation/Activation Log", typeof(MyPages.ActivationLogPage), icon: "fa-circle-o")]
[assembly: NavigationLink(10005, "Activation/Activation", typeof(MyPages.ActivationPage), icon: "fa-circle-o")]


