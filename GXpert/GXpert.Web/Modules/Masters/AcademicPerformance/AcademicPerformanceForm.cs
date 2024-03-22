using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.AcademicPerformance")]
[BasedOnRow(typeof(AcademicPerformanceRow), CheckNames = true)]
public class AcademicPerformanceForm
{
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public int ClassId { get; set; }
    public int SemesterId { get; set; }
    public float MarksObtained { get; set; }
    public float OutOfMarks { get; set; }
    public string Remarks { get; set; }
    public int AcademicYearId { get; set; }
   
}