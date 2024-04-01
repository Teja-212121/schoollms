using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteDivision")]
[BasedOnRow(typeof(InstituteDivisionRow), CheckNames = true)]
public class InstituteDivisionForm
{
    public int InstituteId { get; set; }
    [HalfWidth]
    public int DepartmentId { get; set; }
    [HalfWidth]
    public int CourseId { get; set; }

    [HalfWidth]
    public int ClassId { get; set; }

    [HalfWidth]
    public int SemesterId { get; set; }
    [HalfWidth]
    public string Title { get; set; }
    [HalfWidth]
    public string Division { get; set; }
    [HalfWidth]

    public int ClassTeacherId { get; set; }

    [HalfWidth]
    public int AcademicYearId { get; set; }
    //public int MediumId { get; set; }
    
}