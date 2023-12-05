using Serenity.Navigation;
using MyPages = GXpert.Activation.Pages;

[assembly: NavigationLink(int.MaxValue, "Activation/Coupon Code", typeof(MyPages.CouponCodePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Activation/Serial Key", typeof(MyPages.SerialKeyPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Activation/Activation Log", typeof(MyPages.ActivationLogPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Activation/Activation", typeof(MyPages.ActivationPage), icon: null)]

