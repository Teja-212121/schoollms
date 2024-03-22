using Serenity.Navigation;
using MyPages = GXpert.Users.Pages;

[assembly: NavigationMenu(5000, "Users", icon: "fa fa-users")]
[assembly: NavigationLink(5001, "Users/Teacher", typeof(MyPages.TeacherPage), icon: "fa-circle-o")]
[assembly: NavigationLink(5002, "Users/Student", typeof(MyPages.StudentPage), icon: "fa-circle-o")]
[assembly: NavigationLink(5003, "Users/Principal", typeof(MyPages.PrincipalPage), icon: "fa-circle-o")]
[assembly: NavigationLink(5004, "Users/Hod", typeof(MyPages.HodPage), icon: "fa-circle-o")]