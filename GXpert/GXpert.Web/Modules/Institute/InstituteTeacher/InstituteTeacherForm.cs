using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteTeacher")]
[BasedOnRow(typeof(InstituteTeacherRow), CheckNames = true)]
public class InstituteTeacherForm
{
    public int TeacherId { get; set; }
    public int SchoolId { get; set; }
    public int ClassId { get; set; }
    public int SubjectId { get; set; }
    public string Description { get; set; }
    public int AcademicYearId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}