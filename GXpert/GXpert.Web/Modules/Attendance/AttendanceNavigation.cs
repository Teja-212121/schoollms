using Serenity.Navigation;
using MyPages = GXpert.Attendance.Pages;

[assembly: NavigationMenu(13000, "Attendance", icon: "fa fa-list")]
[assembly: NavigationLink(13001, "Attendance/Raise Hand Live Session", typeof(MyPages.RaiseHandLiveSessionPage), icon: "fa-circle-o")]
[assembly: NavigationLink(13002, "Attendance/Raise Hand Recorded Session", typeof(MyPages.RaiseHandRecordedSessionPage), icon: "fa-circle-o")]
[assembly: NavigationLink(13003, "Attendance/Poll Response", typeof(MyPages.PollResponsePage), icon: "fa-circle-o")]
[assembly: NavigationLink(13004, "Attendance/Assignment Attempt", typeof(MyPages.AssignmentAttemptPage), icon: "fa-circle-o")]
[assembly: NavigationLink(13005, "Attendance/Assignment Attempt Evaluation", typeof(MyPages.AssignmentAttemptEvaluationPage), icon: "fa-circle-o")]
[assembly: NavigationLink(13006, "Attendance/Student Class Attendance", typeof(MyPages.StudentClassAttendancePage), icon: "fa-circle-o")]