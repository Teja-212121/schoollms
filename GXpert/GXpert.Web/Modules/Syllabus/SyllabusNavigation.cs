using Serenity.Navigation;
using MyPages = GXpert.Syllabus.Pages;

[assembly: NavigationLink(int.MaxValue, "Syllabus/Class", typeof(MyPages.ClassPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Syllabus/Subject", typeof(MyPages.SubjectPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Syllabus/Medium", typeof(MyPages.MediumPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Syllabus/Topic", typeof(MyPages.TopicPage), icon: null)]