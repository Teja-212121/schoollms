using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteTimeTable")]
[BasedOnRow(typeof(InstituteTimeTableRow), CheckNames = true)]
public class InstituteTimeTableForm
{
    [HalfWidth]
    public int ClassRoomNo { get; set; }
    [HalfWidth]
    public DateTime Date { get; set; }
    [HalfWidth]
    public DateTime StartTime { get; set; }
    [HalfWidth]
    public DateTime EndTime { get; set; }
    [HalfWidth]
    public int PeriodIndex { get; set; }
    [HalfWidth]
    public int InstituteDivisionId { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
    [HalfWidth]
    public short EType { get; set; }
    [HalfWidth]
    public short TeacherAttendanceStatus {  get; set; }


}