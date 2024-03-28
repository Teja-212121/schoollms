using Serenity.Navigation;
using MyPages = GXpert.Content.Pages;

[assembly: NavigationMenu(6000, "Content", icon: "fa fa-pencil-square-o")]
[assembly: NavigationLink(6001, "Content/Content", typeof(MyPages.ContentPage), icon: "fa-circle-o")]
[assembly: NavigationLink(6002, "Content/Content Blooms Index", typeof(MyPages.ContentBloomsIndexPage), icon: "fa-circle-o")]
[assembly: NavigationLink(6003, "Content/Content Topic", typeof(MyPages.ContentTopicPage), icon: "fa-circle-o")]
[assembly: NavigationLink(int.MaxValue, "Content/Content", typeof(MyPages.ContentPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Content/Content Category", typeof(MyPages.ContentCategoryPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Content/Content Language", typeof(MyPages.ContentLanguagePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Content/Content License", typeof(MyPages.ContentLicensePage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Content/Content Audio", typeof(MyPages.ContentAudioPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Content/Content Subtitle", typeof(MyPages.ContentSubtitlePage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Content/Content Comment", typeof(MyPages.ContentCommentPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Content/Content Rating", typeof(MyPages.ContentRatingPage), icon: null)]
//[assembly: NavigationLink(int.MaxValue, "Content/Content Media Rating", typeof(MyPages.ContentMediaRatingPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Content/Content Course", typeof(MyPages.ContentCoursePage), icon: null)]