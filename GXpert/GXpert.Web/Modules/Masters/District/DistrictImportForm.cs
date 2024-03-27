using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.DistrictImportForm")]
//[BasedOnRow(typeof(StateRow), CheckNames = true)]
public class DistrictImportForm
{
    [FileUploadEditor, Required]
    public string FileName { get; set; }
}