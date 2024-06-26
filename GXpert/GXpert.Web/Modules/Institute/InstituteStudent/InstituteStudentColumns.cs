using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Institute.Columns;

[ColumnsScript("Institute.InstituteStudent")]
[BasedOnRow(typeof(InstituteStudentRow), CheckNames = true)]
public class InstituteStudentColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string StudentPrn { get; set; }
    public string InstituteName { get; set; }
    [QuickFilter]
    public string ClassTitle { get; set; }
    [EditLink]
    public string Division { get; set; }
    public string RollNumber { get; set; }
    public string Description { get; set; }
    public string AcademicYearName { get; set; }
    public string Semester { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

}