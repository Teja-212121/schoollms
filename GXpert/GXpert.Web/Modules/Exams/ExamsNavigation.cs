using Serenity.Navigation;
using MyPages = GXpert.Exams.Pages;

[assembly: NavigationMenu(8000, "Exams", icon: "fa-pencil-square-o")]
[assembly: NavigationLink(8001, "Exams/Exam", typeof(MyPages.ExamPage), icon: "fa-circle-o")]
//[assembly: NavigationLink(8002, "Exams/Exam Section", typeof(MyPages.ExamSectionPage), icon: "fa-circle-o")]
//[assembly: NavigationLink(8003, "Exams/Exam Question", typeof(MyPages.ExamQuestionPage), icon: "fa-circle-o")]
[assembly: NavigationLink(8004, "Exams/Assignment", typeof(MyPages.AssignmentPage), icon: "fa-circle-o")]
[assembly: NavigationLink(8005, "Exams/Assignment Evaluation", typeof(MyPages.AssignmentEvaluationPage), icon: "fa-circle-o")]