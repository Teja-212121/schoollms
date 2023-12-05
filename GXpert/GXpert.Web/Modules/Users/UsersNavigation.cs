using Serenity.Navigation;
using MyPages = GXpert.Users.Pages;

[assembly: NavigationLink(int.MaxValue, "Users/Teacher", typeof(MyPages.TeacherPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Users/Student", typeof(MyPages.StudentPage), icon: null)]