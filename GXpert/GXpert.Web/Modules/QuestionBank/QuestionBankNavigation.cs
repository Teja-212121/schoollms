using Serenity.Navigation;
using MyPages = GXpert.QuestionBank.Pages;

[assembly: NavigationMenu(7000, "QuestionBank", icon: "fa fa-question")]
[assembly: NavigationLink(7001, "QuestionBank/Question", typeof(MyPages.QuestionPage), icon: "fa-circle-o")]
[assembly: NavigationLink(7002, "QuestionBank/Question Option", typeof(MyPages.QuestionOptionPage), icon: "fa-circle-o")]
[assembly: NavigationLink(7003, "QuestionBank/Common Data", typeof(MyPages.CommonDataPage), icon: "fa-circle-o")]
[assembly: NavigationLink(int.MaxValue, "QuestionBank/Question Course", typeof(MyPages.QuestionCoursePage), icon: null)]