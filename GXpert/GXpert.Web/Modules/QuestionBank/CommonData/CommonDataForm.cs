using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.CommonData")]
[BasedOnRow(typeof(CommonDataRow), CheckNames = true)]
public class CommonDataForm
{
    [HalfWidth]
    public string CommonDataTitle { get; set; }
    [HalfWidth]
    public string CommonData { get; set; }
}