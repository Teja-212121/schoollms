using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.State")]
[BasedOnRow(typeof(StateRow), CheckNames = true)]
public class StateForm
{
    public string Title { get; set; }
    public string ShortName { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}