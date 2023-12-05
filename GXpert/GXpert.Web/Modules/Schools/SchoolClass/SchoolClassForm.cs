using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.SchoolClass")]
[BasedOnRow(typeof(SchoolClassRow), CheckNames = true)]
public class SchoolClassForm
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
}