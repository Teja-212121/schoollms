using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Institute.Columns;

[ColumnsScript("Institute.InstituteTimeTable")]
[BasedOnRow(typeof(InstituteTimeTableRow), CheckNames = true)]
public class InstituteTimeTableColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int PeriodIndex { get; set; }
    public string TeacherPrn { get; set; }
    [QuickFilter]
    public string InstituteName { get; set; }
    [QuickFilter]
    public string DepartmentName { get; set; }
    [QuickFilter]
    public string BranchName { get; set; }
    [QuickFilter]
    public string InstitudeDivisionName { get; set; }
    public short EType { get; set; }
    public int ClassRoomNo { get;set; }
    public short TeacherAttendanceStatus { get; set;}
    
}