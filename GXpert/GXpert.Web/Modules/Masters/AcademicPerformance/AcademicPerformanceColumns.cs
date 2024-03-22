using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.AcademicPerformance")]
[BasedOnRow(typeof(AcademicPerformanceRow), CheckNames = true)]
public class AcademicPerformanceColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string StudentPrn { get; set; }
    public string CourseTitle { get; set; }
    public string ClassTitle { get; set; }
    public string SemesterTitle { get; set; }
    public float MarksObtained { get; set; }
    public float OutOfMarks { get; set; }
    [EditLink]
    public string Remarks { get; set; }
    public string AcademicYearName { get; set; }
    
}