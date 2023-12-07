using Serenity.Navigation;
using MyPages = GXpert.Syllabus.Pages;

[assembly: NavigationMenu(2000, "Syllabus", icon: "fa fa-book")]
[assembly: NavigationLink(2001, "Syllabus/Class", typeof(MyPages.ClassPage), icon: "fa-circle-o")]
[assembly: NavigationLink(2002, "Syllabus/Subject", typeof(MyPages.SubjectPage), icon: "fa-circle-o")]
[assembly: NavigationLink(2003, "Syllabus/Medium", typeof(MyPages.MediumPage), icon: "fa-circle-o")]
[assembly: NavigationLink(2004, "Syllabus/Topic", typeof(MyPages.TopicPage), icon: "fa-circle-o")]