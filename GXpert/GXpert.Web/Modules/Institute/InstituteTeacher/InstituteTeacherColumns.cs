using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Institute.Columns;

[ColumnsScript("Institute.InstituteTeacher")]
[BasedOnRow(typeof(InstituteTeacherRow), CheckNames = true)]
public class InstituteTeacherColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string TeacherPrn { get; set; }
    public string InstituteName { get; set; }
    [QuickFilter]
    public string ClassTitle { get; set; }
    [QuickFilter]
    public string SubjectTitle { get; set; }
    [EditLink]
    public string Description { get; set; }
    public string AcademicYearName { get; set; }
     public string Semester { get; set; }
    public string InstituteDivision{ get; set; }


}