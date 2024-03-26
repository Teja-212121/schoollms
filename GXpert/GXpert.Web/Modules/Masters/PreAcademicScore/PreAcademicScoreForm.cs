using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.PreAcademicScore")]
[BasedOnRow(typeof(PreAcademicScoreRow), CheckNames = true)]
public class PreAcademicScoreForm
{
    [HalfWidth]
    public int PreAcadamicsId { get; set; }
    [HalfWidth]
    public DateTime PassedOutDate { get; set; }
    [HalfWidth]
    public float MarksObtained { get; set; }
    [HalfWidth]
    public float OutOfMarks { get; set; }
    [HalfWidth]
    public int StudentId { get; set; }
    [HalfWidth]
    public string Remarks { get; set; }
  
}