using Serenity.ComponentModel;
using System;

namespace GXpert.Activation.Forms;

[FormScript("Activation.Activation")]
[BasedOnRow(typeof(ActivationRow), CheckNames = true)]
public class ActivationForm
{
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
    [HalfWidth]
    public int ActivationLogId { get; set; }
    [HalfWidth]
    public string DeviceId { get; set; }
    [HalfWidth]
    public string DeviceDetails { get; set; }
    [HalfWidth]
    public DateTime ActivationDate { get; set; }
    [HalfWidth]
    public DateTime ExpiryDate { get; set; }
    [HalfWidth]
    public short EStatus { get; set; }
}