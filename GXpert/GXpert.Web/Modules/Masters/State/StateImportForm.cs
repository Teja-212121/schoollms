using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.StateImportForm")]
//[BasedOnRow(typeof(StateRow), CheckNames = true)]
public class StateImportForm
{
    [FileUploadEditor, Required]
    public string FileName { get; set; }
}