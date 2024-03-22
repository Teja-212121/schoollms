using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.InstituteTimeTable")]
[BasedOnRow(typeof(InstituteTimeTableRow), CheckNames = true)]
public class InstituteTimeTableForm
{
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int PeriodIndex { get; set; }
    public int SchoolClassId { get; set; }
    public int TeacherId { get; set; }
    public short EType { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}