using Serenity.Navigation;
using MyPages = GXpert.Attendance.Pages;

[assembly: NavigationLink(int.MaxValue, "Attendance/Raise Hand Live Session", typeof(MyPages.RaiseHandLiveSessionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Attendance/Raise Hand Recorded Session", typeof(MyPages.RaiseHandRecordedSessionPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Attendance/Poll Response", typeof(MyPages.PollResponsePage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Attendance/Assignment Attempt", typeof(MyPages.AssignmentAttemptPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Attendance/Assignment Attempt Evaluation", typeof(MyPages.AssignmentAttemptEvaluationPage), icon: null)]