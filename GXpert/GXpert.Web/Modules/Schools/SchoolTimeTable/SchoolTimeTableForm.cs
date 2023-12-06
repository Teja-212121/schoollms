using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.SchoolTimeTable")]
[BasedOnRow(typeof(SchoolTimeTableRow), CheckNames = true)]
public class SchoolTimeTableForm
{
    public DateTime Date { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int PeriodIndex { get; set; }
    public int SchoolClassId { get; set; }
    public int TeacherId { get; set; }
    public string EType { get; set; }
}