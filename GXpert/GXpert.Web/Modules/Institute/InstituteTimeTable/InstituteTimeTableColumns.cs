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
    public string SchoolClassDivision { get; set; }
    public string TeacherPrn { get; set; }
    public short EType { get; set; }
    
}