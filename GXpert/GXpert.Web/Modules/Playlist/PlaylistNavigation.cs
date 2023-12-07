using Serenity.Navigation;
using MyPages = GXpert.Playlist.Pages;

[assembly: NavigationMenu(9000, "Playlist", icon: "fa-sharp fa-light fa-play")]
[assembly: NavigationLink(9001, "Playlist/Play List", typeof(MyPages.PlayListPage), icon: "fa-circle-o")]
[assembly: NavigationLink(9002, "Playlist/Module", typeof(MyPages.ModulePage), icon: "fa-circle-o")]
[assembly: NavigationLink(9003, "Playlist/Play List Content", typeof(MyPages.PlayListContentPage), icon: "fa-circle-o")]