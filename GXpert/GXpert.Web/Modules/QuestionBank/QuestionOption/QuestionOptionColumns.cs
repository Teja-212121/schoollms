using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank.Columns;

[ColumnsScript("QuestionBank.QuestionOption")]
[BasedOnRow(typeof(QuestionOptionRow), CheckNames = true)]
public class QuestionOptionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public long Id { get; set; }
    public string QuestionText { get; set; }
    [EditLink]
    public string OptionText { get; set; }
    public bool IsCorrect { get; set; }
    public float SortOrder { get; set; }
    public float Weightage { get; set; }
}