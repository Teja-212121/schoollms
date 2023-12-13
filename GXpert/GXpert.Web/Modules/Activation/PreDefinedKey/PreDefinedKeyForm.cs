using Serenity.ComponentModel;
using System;

namespace GXpert.Activation.Forms;

[FormScript("Activation.PreDefinedKey")]
[BasedOnRow(typeof(PreDefinedKeyRow), CheckNames = true)]
public class PreDefinedKeyForm
{
    public string SerialKey { get; set; }
    public short EStatus { get; set; }
    
}