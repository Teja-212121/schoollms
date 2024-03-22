using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.PreAcademic")]
[BasedOnRow(typeof(PreAcademicRow), CheckNames = true)]
public class PreAcademicForm
{
    public string ExamName { get; set; }
    public string Description { get; set; }
    public string Thumbnail { get; set; }
   
}