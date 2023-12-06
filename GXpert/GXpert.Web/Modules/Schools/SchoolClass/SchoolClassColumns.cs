using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Schools.Columns;

[ColumnsScript("Schools.SchoolClass")]
[BasedOnRow(typeof(SchoolClassRow), CheckNames = true)]
public class SchoolClassColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ClassTitle { get; set; }
    [EditLink]
    public string Division { get; set; }
    public string MediumTitle { get; set; }
    public string ClassTeacherPrn { get; set; }
    public string Title { get; set; }
    public string AcademicYearName { get; set; }
}