using Serenity.Navigation;
using MyPages = GXpert.Content.Pages;

[assembly: NavigationMenu(6000, "Content", icon: "fa fa-pencil-square-o")]
[assembly: NavigationLink(6001, "Content/Content", typeof(MyPages.ContentPage), icon: "fa-circle-o")]
[assembly: NavigationLink(6002, "Content/Content Blooms Index", typeof(MyPages.ContentBloomsIndexPage), icon: "fa-circle-o")]
[assembly: NavigationLink(6003, "Content/Content Topic", typeof(MyPages.ContentTopicPage), icon: "fa-circle-o")]