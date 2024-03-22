using Serenity.Navigation;
using MyPages = GXpert.Masters.Pages;

[assembly: NavigationMenu(3000, "Masters", icon: "fa fa-asterisk")]
[assembly: NavigationLink(3001, "Masters/State", typeof(MyPages.StatePage), icon: "fa-circle-o")]
[assembly: NavigationLink(3002, "Masters/District", typeof(MyPages.DistrictPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3003, "Masters/Taluka", typeof(MyPages.TalukaPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3004, "Masters/Academic Year", typeof(MyPages.AcademicYearPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3005, "Masters/Blooms Taxanomy", typeof(MyPages.BloomsTaxanomyPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3006, "Masters/Pre Academic", typeof(MyPages.PreAcademicPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3007, "Masters/Pre Academic Score", typeof(MyPages.PreAcademicScorePage), icon: "fa-circle-o")]
[assembly: NavigationLink(3008, "Masters/Academic Performance", typeof(MyPages.AcademicPerformancePage), icon: "fa-circle-o")]
[assembly: NavigationLink(3009, "Masters/Academic Subject Performance", typeof(MyPages.AcademicSubjectPerformancePage), icon: "fa-circle-o")]
[assembly: NavigationLink(3010, "Masters/Project", typeof(MyPages.ProjectPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3011, "Masters/Project Skill", typeof(MyPages.ProjectSkillPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3012, "Masters/User Skills Score", typeof(MyPages.UserSkillsScorePage), icon: "fa-circle-o")]
[assembly: NavigationLink(3013, "Masters/User Academic", typeof(MyPages.UserAcademicPage), icon: "fa-circle-o")]