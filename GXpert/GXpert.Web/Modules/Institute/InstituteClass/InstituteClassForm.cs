using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteClass")]
[BasedOnRow(typeof(InstituteClassRow), CheckNames = true)]
public class InstituteClassForm
{
    public int ClassId { get; set; }
    public string Division { get; set; }
    public int MediumId { get; set; }
    public int ClassTeacherId { get; set; }
    public string Title { get; set; }
    public int AcademicYearId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
    public int InstituteId { get; set; }
    public int DepartmentId { get; set; }
    public int CourseId { get; set; }
}