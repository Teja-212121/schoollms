using Serenity.ComponentModel;
using System;

namespace GXpert.Masters.Forms;

[FormScript("Masters.AcademicSubjectPerformanceImportForm")]

public class AcademicSubjectPerformanceImportForm
{
    [FileUploadEditor, Required]
    [HalfWidth]
    public string FileName { get; set; }

}