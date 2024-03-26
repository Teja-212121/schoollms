using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.SubjectExelImportForm")]
//[BasedOnRow(typeof(SubjectRow), CheckNames = true)]
public class SubjectExcelImportForm
{
    [FileUploadEditor, Required]
    public String FileName { get; set; }

}