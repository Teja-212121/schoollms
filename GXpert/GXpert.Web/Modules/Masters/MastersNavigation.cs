using Serenity.Navigation;
using MyPages = GXpert.Masters.Pages;

[assembly: NavigationMenu(3000, "Masters", icon: "fa fa-asterisk")]
[assembly: NavigationLink(3001, "Masters/State", typeof(MyPages.StatePage), icon: "fa-circle-o")]
[assembly: NavigationLink(3002, "Masters/District", typeof(MyPages.DistrictPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3003, "Masters/Taluka", typeof(MyPages.TalukaPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3004, "Masters/Academic Year", typeof(MyPages.AcademicYearPage), icon: "fa-circle-o")]
[assembly: NavigationLink(3005, "Masters/Blooms Taxanomy", typeof(MyPages.BloomsTaxanomyPage), icon: "fa-circle-o")]