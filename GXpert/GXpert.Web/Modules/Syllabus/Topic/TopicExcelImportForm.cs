using Serenity.ComponentModel;
using System;

namespace GXpert.Syllabus.Forms;

[FormScript("Syllabus.TopicExcelImport")]
//[BasedOnRow(typeof(TopicRow), CheckNames = true)]
public class TopicExcelImportForm
{
    [FileUploadEditor, Required]
    public String FileName { get; set; }

}