using Serenity.ComponentModel;
using System;

namespace GXpert.QuestionBank.Forms;

[FormScript("QuestionBank.QuestionOption")]
[BasedOnRow(typeof(QuestionOptionRow), CheckNames = true)]
public class QuestionOptionForm
{
    [HalfWidth]
    public long QuestionId { get; set; }
    public string OptionText { get; set; }
    [HalfWidth]
    public bool IsCorrect { get; set; }
    [HalfWidth]
    public float SortOrder { get; set; }
    [HalfWidth]
    public float Weightage { get; set; }
}