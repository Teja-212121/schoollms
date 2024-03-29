using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.AcademicPerformanceImportForm")]
//[BasedOnRow(typeof(PreAcademicScoreRow), CheckNames = true)]
public class AcademicPerformanceImportForm
{
    [FileUploadEditor, Required]
    [HalfWidth]
    public string FileName { get; set; }

}