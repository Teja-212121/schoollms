using Serenity.Navigation;
using MyPages = GXpert.LiveSessions.Pages;

[assembly: NavigationMenu(11000, "LiveSessions", icon: "fa fa-video-camera")]
[assembly: NavigationLink(11001, "LiveSessions/Live Session", typeof(MyPages.LiveSessionPage), icon: "fa-circle-o")]
[assembly: NavigationLink(11002, "LiveSessions/Live Session Log", typeof(MyPages.LiveSessionLogPage), icon: "fa-circle-o")]
[assembly: NavigationLink(11003, "LiveSessions/Poll", typeof(MyPages.PollPage), icon: "fa-circle-o")]