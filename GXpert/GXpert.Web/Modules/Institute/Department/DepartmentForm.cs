using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.Department")]
[BasedOnRow(typeof(DepartmentRow), CheckNames = true)]
public class DepartmentForm
{
    public string Title { get; set; }
    public int InstituteId { get; set; }
    public int HodId { get; set; }
    public string Description { get; set; }
  
}