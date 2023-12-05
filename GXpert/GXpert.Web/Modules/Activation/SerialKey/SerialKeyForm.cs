using Serenity.ComponentModel;
using System;

namespace GXpert.Activation.Forms;

[FormScript("Activation.SerialKey")]
[BasedOnRow(typeof(SerialKeyRow), CheckNames = true)]
public class SerialKeyForm
{
    public string SerialKey { get; set; }
    public int PlayListId { get; set; }
    public short ValidityType { get; set; }
    public short ValidityInDays { get; set; }
    public DateTime ValidDate { get; set; }
    public string Note { get; set; }
    public short EStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}