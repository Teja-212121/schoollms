using Serenity.ComponentModel;
using System;

namespace GXpert.Activation.Forms;

[FormScript("Activation.ActivationLog")]
[BasedOnRow(typeof(ActivationLogRow), CheckNames = true)]
public class ActivationLogForm
{
    [HalfWidth]
    public string Code { get; set; }
    [HalfWidth]
    public string SerialKey { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public string DeviceId { get; set; }
    [HalfWidth]
    public string DeviceDetails { get; set; }
    [HalfWidth]
    public short EStatus { get; set; }
    [HalfWidth]
    public string Note { get; set; }
}