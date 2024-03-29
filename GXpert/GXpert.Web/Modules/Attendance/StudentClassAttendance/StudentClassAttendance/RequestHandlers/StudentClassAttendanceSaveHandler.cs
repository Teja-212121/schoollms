using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<GXpert.Attendance.StudentClassAttendanceRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = GXpert.Attendance.StudentClassAttendanceRow;

namespace GXpert.Attendance;

public interface IStudentClassAttendanceSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }

public class StudentClassAttendanceSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IStudentClassAttendanceSaveHandler
{
    public StudentClassAttendanceSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}