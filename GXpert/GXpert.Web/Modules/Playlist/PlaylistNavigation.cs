using Serenity.Navigation;
using MyPages = GXpert.Playlist.Pages;

[assembly: NavigationLink(int.MaxValue, "Playlist/Play List", typeof(MyPages.PlayListPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Playlist/Module", typeof(MyPages.ModulePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Playlist/Play List Content", typeof(MyPages.PlayListContentPage), icon: null)]