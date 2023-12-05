using Serenity.Navigation;
using MyPages = GXpert.LiveSessions.Pages;

[assembly: NavigationLink(int.MaxValue, "LiveSessions/Live Session", typeof(MyPages.LiveSessionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "LiveSessions/Live Session Log", typeof(MyPages.LiveSessionLogPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "LiveSessions/Poll", typeof(MyPages.PollPage), icon: null)]