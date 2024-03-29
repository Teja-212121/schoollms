using Serenity.Navigation;
using MyPages = GXpert.Content.Pages;

[assembly: NavigationMenu(6000, "Content", icon: "fa fa-pencil-square-o")]
[assembly: NavigationLink(6001, "Content/Content", typeof(MyPages.ContentPage), icon: "fa-circle-o")]
[assembly: NavigationLink(6002, "Content/Content Blooms Index", typeof(MyPages.ContentBloomsIndexPage), icon: "fa-circle-o")]
[assembly: NavigationLink(6003, "Content/Content Topic", typeof(MyPages.ContentTopicPage), icon: "fa-circle-o")]

[assembly: NavigationLink(6004, "Content/Content Category", typeof(MyPages.ContentCategoryPage), icon: "fa-circle-o")]


[assembly: NavigationLink(6005, "Content/Content Rating", typeof(MyPages.ContentRatingPage), icon: "fa-circle-o")]

[assembly: NavigationLink(6006, "Content/Content Course", typeof(MyPages.ContentCoursePage), icon: "fa-circle-o")]


[assembly: NavigationMenu(150014, "Masters/Content", icon: "fa fa-pencil-square-o")]
[assembly: NavigationLink(150015, "Masters/Content/Content Language", typeof(MyPages.ContentLanguagePage), icon: "fa-circle-o")]
[assembly: NavigationLink(150016, "Masters/Content/Content License", typeof(MyPages.ContentLicensePage), icon: "fa-circle-o")]
