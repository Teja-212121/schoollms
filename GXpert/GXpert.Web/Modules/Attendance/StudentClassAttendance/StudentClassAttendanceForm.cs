using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.StudentClassAttendance")]
[BasedOnRow(typeof(StudentClassAttendanceRow), CheckNames = true)]
public class StudentClassAttendanceForm
{
    [HalfWidth]
    public int InstituteTimeTableId { get; set; }
    [HalfWidth]
    public int StudentId { get; set; }
    [HalfWidth]
    public short AttendanceStatus { get; set; }
   
}