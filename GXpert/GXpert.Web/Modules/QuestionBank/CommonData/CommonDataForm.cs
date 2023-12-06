using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.CommonData")]
[BasedOnRow(typeof(CommonDataRow), CheckNames = true)]
public class CommonDataForm
{
    public string CommonDataTitle { get; set; }
    public string CommonData { get; set; }
}