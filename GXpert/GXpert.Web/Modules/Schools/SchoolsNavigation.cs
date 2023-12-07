using Serenity.Navigation;
using MyPages = GXpert.Schools.Pages;

[assembly: NavigationMenu(4000, "Schools", icon: "fa fa-graduation-cap")]
[assembly: NavigationLink(4001, "Schools/School", typeof(MyPages.SchoolPage), icon: "fa-circle-o")]
[assembly: NavigationLink(4002, "Schools/School Class", typeof(MyPages.SchoolClassPage), icon: "fa-circle-o")]
[assembly: NavigationLink(4003, "Schools/School Teacher", typeof(MyPages.SchoolTeacherPage), icon: "fa-circle-o")]
[assembly: NavigationLink(4004, "Schools/School Student", typeof(MyPages.SchoolStudentPage), icon: "fa-circle-o")]
[assembly: NavigationLink(4005, "Schools/School Time Table", typeof(MyPages.SchoolTimeTablePage), icon: "fa-circle-o")]