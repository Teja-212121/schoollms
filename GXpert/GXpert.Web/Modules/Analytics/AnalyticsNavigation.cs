using Serenity.Navigation;
using MyPages = GXpert.Analytics.Pages;

[assembly: NavigationMenu(12000, "Analytics", icon: "fa fa-bar-chart")]
[assembly: NavigationLink(12001, "Analytics/Analytics Log", typeof(MyPages.AnalyticsLogPage), icon: "fa-circle-o")]
[assembly: NavigationLink(12002, "Analytics/Exam Attempt", typeof(MyPages.ExamAttemptPage), icon: "fa-circle-o")]
[assembly: NavigationLink(12003, "Analytics/Exam Attempt Question", typeof(MyPages.ExamAttemptQuestionPage), icon: "fa-circle-o")]
[assembly: NavigationLink(12004, "Analytics/Assigned Exam Teachers", typeof(MyPages.AssignedExamTeachersPage), icon: "fa-circle-o")]
