using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.SchoolTeacher")]
[BasedOnRow(typeof(SchoolTeacherRow), CheckNames = true)]
public class SchoolTeacherForm
{
    [HalfWidth]
    public int TeacherId { get; set; }
    [HalfWidth]
    public int SchoolId { get; set; }
    [HalfWidth]
    public int ClassId { get; set; }
    [HalfWidth]
    public int SubjectId { get; set; }
    [TextAreaEditor(Rows =3)]
    public string Description { get; set; }
    [HalfWidth]
    public int AcademicYearId { get; set; }
}