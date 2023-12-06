using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.QuestionOption")]
[BasedOnRow(typeof(QuestionOptionRow), CheckNames = true)]
public class QuestionOptionForm
{
    public long QuestionId { get; set; }
    public string OptionText { get; set; }
    public bool IsCorrect { get; set; }
    public float SortOrder { get; set; }
    public float Weightage { get; set; }
}