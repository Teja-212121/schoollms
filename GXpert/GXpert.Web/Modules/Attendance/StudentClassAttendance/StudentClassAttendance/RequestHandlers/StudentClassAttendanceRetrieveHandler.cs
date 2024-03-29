using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<GXpert.Attendance.StudentClassAttendanceRow>;
using MyRow = GXpert.Attendance.StudentClassAttendanceRow;

namespace GXpert.Attendance;

public interface IStudentClassAttendanceRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> { }

public class StudentClassAttendanceRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IStudentClassAttendanceRetrieveHandler
{
    public StudentClassAttendanceRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}