using Serenity.Navigation;
using MyPages = GXpert.Skills.Pages;


[assembly: NavigationMenu(15000, "Skills", icon: "fa-solid fa-star" )]
[assembly: NavigationLink(15001, "Skills/Skill Category", typeof(MyPages.SkillCategoryPage), icon: "fa-circle-o")]
[assembly: NavigationLink(15002, "Skills/Skill", typeof(MyPages.SkillPage), icon: "fa-circle-o")]