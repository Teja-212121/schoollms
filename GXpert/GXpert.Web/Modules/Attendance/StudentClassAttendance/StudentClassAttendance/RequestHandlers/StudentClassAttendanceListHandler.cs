using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<GXpert.Attendance.StudentClassAttendanceRow>;
using MyRow = GXpert.Attendance.StudentClassAttendanceRow;

namespace GXpert.Attendance;

public interface IStudentClassAttendanceListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

public class StudentClassAttendanceListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IStudentClassAttendanceListHandler
{
    public StudentClassAttendanceListHandler(IRequestContext context)
            : base(context)
    {
    }
}