using Serenity.Navigation;
using MyPages = GXpert.Schools.Pages;

[assembly: NavigationLink(int.MaxValue, "Schools/School", typeof(MyPages.SchoolPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Schools/School Class", typeof(MyPages.SchoolClassPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Schools/School Teacher", typeof(MyPages.SchoolTeacherPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Schools/School Student", typeof(MyPages.SchoolStudentPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Schools/School Time Table", typeof(MyPages.SchoolTimeTablePage), icon: null)]