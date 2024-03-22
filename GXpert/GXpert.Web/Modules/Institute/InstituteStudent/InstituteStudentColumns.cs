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
    public string SchoolName { get; set; }
    public string ClassTitle { get; set; }
    [EditLink]
    public string Division { get; set; }
    public string RollNumber { get; set; }
    public string Description { get; set; }
    public string AcademicYearName { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}