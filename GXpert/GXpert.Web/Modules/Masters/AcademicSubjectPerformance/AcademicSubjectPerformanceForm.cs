using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.AcademicSubjectPerformance")]
[BasedOnRow(typeof(AcademicSubjectPerformanceRow), CheckNames = true)]
public class AcademicSubjectPerformanceForm
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public int ClassId { get; set; }
    public int SemesterId { get; set; }
    public int SubjectId { get; set; }
    public short ETypeOfExam { get; set; }
    public float MarksObtained { get; set; }
    public float OutOfMarks { get; set; }
    public string Remarks { get; set; }
    public int AcademicYearId { get; set; }
  
}