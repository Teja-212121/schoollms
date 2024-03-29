using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.PreAcademicScoreImportForm")]
//[BasedOnRow(typeof(PreAcademicScoreRow), CheckNames = true)]
public class PreAcademicScoreImportForm
{
    [FileUploadEditor, Required]
    [HalfWidth]
    public string FileName { get; set; }

}