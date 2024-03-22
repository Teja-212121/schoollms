using Serenity.Navigation;
using MyPages = GXpert.Institute.Pages;

[assembly: NavigationLink(int.MaxValue, "Institute/Institute", typeof(MyPages.InstitutePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Institute/Institute Class", typeof(MyPages.InstituteClassPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Institute/Institute Student", typeof(MyPages.InstituteStudentPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Institute/Institute Teacher", typeof(MyPages.InstituteTeacherPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Institute/Institute Time Table", typeof(MyPages.InstituteTimeTablePage), icon: null)]