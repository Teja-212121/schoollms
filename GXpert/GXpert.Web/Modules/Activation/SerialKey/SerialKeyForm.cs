using Serenity.ComponentModel;
using System;

namespace GXpert.Activation.Forms;

[FormScript("Activation.SerialKey")]
[BasedOnRow(typeof(SerialKeyRow), CheckNames = true)]
public class SerialKeyForm
{
    [HalfWidth]
    public string SerialKey { get; set; }
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public short ValidityType { get; set; }
    [HalfWidth]
    public short ValidityInDays { get; set; }
    [HalfWidth]
    public DateTime ValidDate { get; set; }
    [HalfWidth]
    public string Note { get; set; }
    [HalfWidth]
    public short EStatus { get; set; }
}