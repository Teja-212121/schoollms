using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = GXpert.Attendance.StudentClassAttendanceRow;

namespace GXpert.Attendance;

public interface IStudentClassAttendanceDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> { }

public class StudentClassAttendanceDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IStudentClassAttendanceDeleteHandler
{
    public StudentClassAttendanceDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}