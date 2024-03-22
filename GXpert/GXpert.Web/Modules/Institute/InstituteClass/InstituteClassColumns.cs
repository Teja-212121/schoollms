using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Institute.Columns;

[ColumnsScript("Institute.InstituteClass")]
[BasedOnRow(typeof(InstituteClassRow), CheckNames = true)]
public class InstituteClassColumns
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
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
    public string InstituteName { get; set; }
    public string DepartmentTitle { get; set; }
    public string CourseTitle { get; set; }
}