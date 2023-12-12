using Serenity.ComponentModel;
using System;

namespace GXpert.Activation.Forms;

[FormScript("Activation.PreDefinedKey")]
[BasedOnRow(typeof(PreDefinedKeyRow), CheckNames = true)]
public class PreDefinedKeyForm
{
    public string SerialKey { get; set; }
    public short EStatus { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public short IsActive { get; set; }
}