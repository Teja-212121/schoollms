using Serenity.Navigation;
using MyPages = GXpert.Masters.Pages;

[assembly: NavigationLink(int.MaxValue, "Masters/State", typeof(MyPages.StatePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Masters/District", typeof(MyPages.DistrictPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Masters/Taluka", typeof(MyPages.TalukaPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Masters/Academic Year", typeof(MyPages.AcademicYearPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Masters/Blooms Taxanomy", typeof(MyPages.BloomsTaxanomyPage), icon: null)]