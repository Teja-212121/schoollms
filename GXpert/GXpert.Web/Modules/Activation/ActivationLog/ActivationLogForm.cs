using Serenity.ComponentModel;
using System;

namespace GXpert.Activation.Forms;

[FormScript("Activation.ActivationLog")]
[BasedOnRow(typeof(ActivationLogRow), CheckNames = true)]
public class ActivationLogForm
{
    public string Code { get; set; }
    public string SerialKey { get; set; }
    public int TeacherId { get; set; }
    public int PlayListId { get; set; }
    public string DeviceId { get; set; }
    public string DeviceDetails { get; set; }
    public short EStatus { get; set; }
    public string Note { get; set; }
}