using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.QuestionExcellmportForm")]
//[BasedOnRow(typeof(QuestionRow), CheckNames = true)]
public class QuestionExcellmportForm
{
    [FileUploadEditor, Required, IgnoreName]
    public String FileName { get; set; }
}
