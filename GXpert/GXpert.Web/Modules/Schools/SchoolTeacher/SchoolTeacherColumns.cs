using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Schools.Columns;

[ColumnsScript("Schools.SchoolTeacher")]
[BasedOnRow(typeof(SchoolTeacherRow), CheckNames = true)]
public class SchoolTeacherColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string TeacherPrn { get; set; }
    public string SchoolName { get; set; }
    public string ClassTitle { get; set; }
    public string SubjectTitle { get; set; }
    [EditLink]
    public string Description { get; set; }
    public string AcademicYearName { get; set; }
}