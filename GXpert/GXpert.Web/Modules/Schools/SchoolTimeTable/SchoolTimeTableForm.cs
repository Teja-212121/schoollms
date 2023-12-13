using Serenity.ComponentModel;
using System;

namespace GXpert.Schools.Forms;

[FormScript("Schools.SchoolTimeTable")]
[BasedOnRow(typeof(SchoolTimeTableRow), CheckNames = true)]
public class SchoolTimeTableForm
{
    [HalfWidth]
    public DateTime Date { get; set; }
    [HalfWidth]
    public DateTime StartTime { get; set; }
    [HalfWidth]
    public DateTime EndTime { get; set; }
    [HalfWidth]
    public int PeriodIndex { get; set; }
    [HalfWidth]
    public int SchoolClassId { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
    [HalfWidth]
    public short EType { get; set; }
}