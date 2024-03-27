using Serenity.Navigation;
using MyPages = GXpert.Skills.Pages;


[assembly: NavigationMenu(15009, "Masters/Skills", icon: "fa-solid fa-star")]
[assembly: NavigationLink(150010, "Masters/Skills/Skill Category", typeof(MyPages.SkillCategoryPage), icon: "fa-circle-o")]
[assembly: NavigationLink(150011, "Masters/Skills/Skill", typeof(MyPages.SkillPage), icon: "fa-circle-o")]