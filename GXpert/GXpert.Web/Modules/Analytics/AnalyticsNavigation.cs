using Serenity.Navigation;
using MyPages = GXpert.Analytics.Pages;

[assembly: NavigationLink(int.MaxValue, "Analytics/Analytics Log", typeof(MyPages.AnalyticsLogPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Analytics/Exam Attempt", typeof(MyPages.ExamAttemptPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Analytics/Exam Attempt Question", typeof(MyPages.ExamAttemptQuestionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Analytics/Assigned Exam Teachers", typeof(MyPages.AssignedExamTeachersPage), icon: null)]
