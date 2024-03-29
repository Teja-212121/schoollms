using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.StudentClassAttendanceExcelImportForm")]
//[BasedOnRow(typeof(StudentClassAttendanceRow), CheckNames = true)]
public class StudentClassAttendanceExcelImportForm
{
    [FileUploadEditor, Required, IgnoreName]
    public String FileName { get; set; }

}