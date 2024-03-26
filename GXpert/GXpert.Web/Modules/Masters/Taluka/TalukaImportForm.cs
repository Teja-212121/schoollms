using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.TalukaImportForm")]
//[BasedOnRow(typeof(TalukaRow), CheckNames = true)]
public class TalukaImportForm
{
    [FileUploadEditor, Required]
    [HalfWidth]
    public string FileName { get; set; }
}