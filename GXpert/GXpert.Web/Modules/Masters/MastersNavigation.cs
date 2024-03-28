using Serenity.Navigation;
using MyPages = GXpert.Masters.Pages;

[assembly: NavigationMenu(15000, "Masters", icon: "fa fa-asterisk")]
[assembly: NavigationMenu(15001, "Masters/Region", icon: "fa-circle-o")]
[assembly: NavigationLink(15002, "Masters/Region/State", typeof(MyPages.StatePage), icon: "fa-circle-o")]
[assembly: NavigationLink(15003, "Masters/Region/District", typeof(MyPages.DistrictPage), icon: "fa-circle-o")]
[assembly: NavigationLink(15004, "Masters/Region/Taluka", typeof(MyPages.TalukaPage), icon: "fa-circle-o")]
[assembly: NavigationMenu(15005, "Masters/Academic", icon: "fa-circle-o")]
[assembly: NavigationLink(15006, "Masters/Academic/Academic Year", typeof(MyPages.AcademicYearPage), icon: "fa-circle-o")]
[assembly: NavigationLink(15007, "Masters/Academic/Blooms Taxanomy", typeof(MyPages.BloomsTaxanomyPage), icon: "fa-circle-o")]
[assembly: NavigationLink(15008, "Masters/Academic/Pre Academic", typeof(MyPages.PreAcademicPage), icon: "fa-circle-o")]

//[assembly: NavigationMenu(3000, "PreAcademic", icon: "fa fa-asterisk")]

//[assembly: NavigationLink(3001, "PreAcademic/Pre Academic Score", typeof(MyPages.PreAcademicScorePage), icon: "fa-circle-o")]
//[assembly: NavigationLink(3002, "PreAcademic/Academic Performance", typeof(MyPages.AcademicPerformancePage), icon: "fa-circle-o")]
//[assembly: NavigationLink(3003, "PreAcademic/Academic Subject Performance", typeof(MyPages.AcademicSubjectPerformancePage), icon: "fa-circle-o")]
//[assembly: NavigationLink(3004, "PreAcademic/Project", typeof(MyPages.ProjectPage), icon: "fa-circle-o")]
//[assembly: NavigationLink(3005, "PreAcademic/Project Skill", typeof(MyPages.ProjectSkillPage), icon: "fa-circle-o")]
//[assembly: NavigationLink(3006, "PreAcademic/User Skills Score", typeof(MyPages.UserSkillsScorePage), icon: "fa-circle-o")]
//[assembly: NavigationLink(3007, "PreAcademic/User Academic", typeof(MyPages.UserAcademicPage), icon: "fa-circle-o")]