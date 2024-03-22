using Serenity.Navigation;
using MyPages = GXpert.Syllabus.Pages;

[assembly: NavigationMenu(2000, "Syllabus", icon: "fa fa-book")]
[assembly: NavigationLink(2001, "Syllabus/Course", typeof(MyPages.CoursePage), icon: "fa-circle-o")]
[assembly: NavigationLink(2002, "Syllabus/Class", typeof(MyPages.ClassPage), icon: "fa-circle-o")]
[assembly: NavigationLink(2003, "Syllabus/Semester", typeof(MyPages.SemesterPage), icon: "fa-circle-o")]
[assembly: NavigationLink(2004, "Syllabus/Subject", typeof(MyPages.SubjectPage), icon: "fa-circle-o")]
/*[assembly: NavigationLink(2003, "Syllabus/Medium", typeof(MyPages.MediumPage), icon: "fa-circle-o")]*/
[assembly: NavigationLink(2005, "Syllabus/Topic", typeof(MyPages.TopicPage), icon: "fa-circle-o")]

