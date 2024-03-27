using Serenity.Navigation;
using MyPages = GXpert.Institute.Pages;

[assembly: NavigationMenu(4000, "Institute", icon: "fa fa-graduation-cap")]
[assembly: NavigationLink(4001, "Institute/Institute", typeof(MyPages.InstitutePage), icon: "fa-circle-o")]
[assembly: NavigationLink(4002, "Institute/Department", typeof(MyPages.DepartmentPage), icon: "fa-circle-o")]
[assembly: NavigationLink(4003, "Institute/Branch", typeof(MyPages.BranchPage), icon: "fa-circle-o")]

[assembly: NavigationLink(4004, "Institute/Institute Division", typeof(MyPages.InstituteDivisionPage), icon: "fa-circle-o")]
//[assembly: NavigationLink(4003, "Institute/Institute Student", typeof(MyPages.InstituteStudentPage), icon: "fa-circle-o")]
[assembly: NavigationLink(4005, "Institute/Institute Teacher", typeof(MyPages.InstituteTeacherPage), icon: "fa-circle-o")]
[assembly: NavigationLink(4006, "Institute/Institute Time Table", typeof(MyPages.InstituteTimeTablePage), icon: "fa-circle-o")]


