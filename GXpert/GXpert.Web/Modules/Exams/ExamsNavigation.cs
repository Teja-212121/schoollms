using Serenity.Navigation;
using MyPages = GXpert.Exams.Pages;

[assembly: NavigationLink(int.MaxValue, "Exams/Exam", typeof(MyPages.ExamPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Exams/Exam Section", typeof(MyPages.ExamSectionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Exams/Exam Question", typeof(MyPages.ExamQuestionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Exams/Assignment", typeof(MyPages.AssignmentPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Exams/Assignment Evaluation", typeof(MyPages.AssignmentEvaluationPage), icon: null)]