using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.Taluka")]
[BasedOnRow(typeof(TalukaRow), CheckNames = true)]
public class TalukaForm
{
    public string Title { get; set; }
    public int StateId { get; set; }
    public int DistrictId { get; set; }
    public string ShortName { get; set; }
}