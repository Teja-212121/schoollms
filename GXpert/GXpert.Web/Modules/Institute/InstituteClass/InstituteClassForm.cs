using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteClass")]
[BasedOnRow(typeof(InstituteClassRow), CheckNames = true)]
public class InstituteClassForm
{
    public int InstituteId { get; set; }
    [HalfWidth]
    public int DepartmentId { get; set; }
    [HalfWidth]
    public int CourseId { get; set; }

    [HalfWidth]
    public int ClassId { get; set; }

    
    public int SemesterId { get; set; }
    [HalfWidth]
    public string Title { get; set; }
    [HalfWidth]
    
    public string Division { get; set; }
    [HalfWidth]
    
    public int ClassTeacherId { get; set; }
        
    [HalfWidth]
    public int AcademicYearId { get; set; }
  
   
}