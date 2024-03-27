using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteTeacher")]
[BasedOnRow(typeof(InstituteTeacherRow), CheckNames = true)]
public class InstituteTeacherForm
{
    [HalfWidth]
    public int InstituteId { get; set; }
      
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SemesterId { get; set; }
   
    [HalfWidth]
    public int SubjectId { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
    [HalfWidth]
    public int InstituteDivisionId { get; set; }

    [HalfWidth]
    public int AcademicYearId { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
   
    
}