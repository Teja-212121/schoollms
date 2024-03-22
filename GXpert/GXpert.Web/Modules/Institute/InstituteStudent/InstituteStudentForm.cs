using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteStudent")]
[BasedOnRow(typeof(InstituteStudentRow), CheckNames = true)]
public class InstituteStudentForm
{
    public int StudentId { get; set; }
    public int SchoolId { get; set; }
    public int ClassId { get; set; }
    public string Division { get; set; }
    public string RollNumber { get; set; }
    public string Description { get; set; }
    public int AcademicYearId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}