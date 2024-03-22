using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.PreAcademicScore")]
[BasedOnRow(typeof(PreAcademicScoreRow), CheckNames = true)]
public class PreAcademicScoreForm
{
    public int PreAcadamicsId { get; set; }
    public DateTime PassedOutDate { get; set; }
    public float MarksObtained { get; set; }
    public float OutOfMarks { get; set; }
    public int StudentId { get; set; }
    public string Remarks { get; set; }
  
}