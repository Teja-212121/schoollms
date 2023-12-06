using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.State")]
[BasedOnRow(typeof(StateRow), CheckNames = true)]
public class StateForm
{
    public string Title { get; set; }
    public string ShortName { get; set; }
}