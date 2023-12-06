using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.District")]
[BasedOnRow(typeof(DistrictRow), CheckNames = true)]
public class DistrictForm
{
    public string Title { get; set; }
    public int StateId { get; set; }
    public string ShortName { get; set; }
}