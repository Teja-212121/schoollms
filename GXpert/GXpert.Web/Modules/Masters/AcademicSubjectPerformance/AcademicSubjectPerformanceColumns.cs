using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Masters.Columns;

[ColumnsScript("Masters.AcademicSubjectPerformance")]
[BasedOnRow(typeof(AcademicSubjectPerformanceRow), CheckNames = true)]
public class AcademicSubjectPerformanceColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string StudentPrn { get; set; }
    public string CourseTitle { get; set; }
    public string ClassTitle { get; set; }
    public string SemesterTitle { get; set; }
    public string SubjectTitle { get; set; }
    public short ETypeOfExam { get; set; }
    public float MarksObtained { get; set; }
    public float OutOfMarks { get; set; }
    [EditLink]
    public string Remarks { get; set; }
    public string AcademicYearName { get; set; }
    
}