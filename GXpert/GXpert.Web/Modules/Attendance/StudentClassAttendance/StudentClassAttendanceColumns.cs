using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Attendance.Columns;

[ColumnsScript("Attendance.StudentClassAttendance")]
[BasedOnRow(typeof(StudentClassAttendanceRow), CheckNames = true)]
public class StudentClassAttendanceColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public int InstituteTimeTableId{ get; set; }
    public string StudentId { get; set; }
    public short AttendanceStatus { get; set; }
}