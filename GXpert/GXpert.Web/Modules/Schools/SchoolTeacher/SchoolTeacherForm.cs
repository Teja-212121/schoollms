using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.SchoolTeacher")]
[BasedOnRow(typeof(SchoolTeacherRow), CheckNames = true)]
public class SchoolTeacherForm
{
    public int TeacherId { get; set; }
    public int SchoolId { get; set; }
    public int ClassId { get; set; }
    public int SubjectId { get; set; }
    public string Description { get; set; }
    public int AcademicYearId { get; set; }
}