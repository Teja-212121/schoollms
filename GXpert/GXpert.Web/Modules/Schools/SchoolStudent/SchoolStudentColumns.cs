using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Schools.Columns;

[ColumnsScript("Schools.SchoolStudent")]
[BasedOnRow(typeof(SchoolStudentRow), CheckNames = true)]
public class SchoolStudentColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string StudentPrn { get; set; }
    public string SchoolName { get; set; }
    public string ClassTitle { get; set; }
    [EditLink]
    public string Division { get; set; }
    public string RollNumber { get; set; }
    public string Description { get; set; }
    public string AcademicYearName { get; set; }
}