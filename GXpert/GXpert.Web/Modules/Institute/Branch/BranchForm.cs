using Serenity.ComponentModel;
using System;

namespace GXpert.Institute.Forms;

[FormScript("Institute.Branch")]
[BasedOnRow(typeof(BranchRow), CheckNames = true)]
public class BranchForm
{
    public int InstituteId { get; set; }
    public int DepartmentId { get; set; }
    public string Title { get; set; }

    public int BranchCode { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }
   
}