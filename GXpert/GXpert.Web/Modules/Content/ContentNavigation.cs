using Serenity.Navigation;
using MyPages = GXpert.Content.Pages;

[assembly: NavigationLink(int.MaxValue, "Content/Content", typeof(MyPages.ContentPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Content/Content Blooms Index", typeof(MyPages.ContentBloomsIndexPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Content/Content Topic", typeof(MyPages.ContentTopicPage), icon: null)]