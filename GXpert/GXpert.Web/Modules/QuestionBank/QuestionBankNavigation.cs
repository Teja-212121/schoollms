using Serenity.Navigation;
using MyPages = GXpert.QuestionBank.Pages;

[assembly: NavigationLink(int.MaxValue, "QuestionBank/Question", typeof(MyPages.QuestionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "QuestionBank/Question Option", typeof(MyPages.QuestionOptionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "QuestionBank/Common Data", typeof(MyPages.CommonDataPage), icon: null)]