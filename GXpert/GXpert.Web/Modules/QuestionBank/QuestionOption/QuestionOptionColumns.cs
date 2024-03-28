using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank.Columns;

[ColumnsScript("QuestionBank.QuestionOption")]
[BasedOnRow(typeof(QuestionOptionRow), CheckNames = true)]
public class QuestionOptionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
   
    [HeaderCssClass("QuestionOption1")]
    public long Id { get; set; }
    [HeaderCssClass("QuestionOption1"), Hidden]
    public string QuestionText { get; set; }
    [HeaderCssClass("QuestionOption1")]
    [EditLink]
    public string OptionText { get; set; }
    [HeaderCssClass("QuestionOption1")]
    public bool IsCorrect { get; set; }
    [HeaderCssClass("QuestionOption1")]
    public float SortOrder { get; set; }
    [HeaderCssClass("QuestionOption1")]
    public float Weightage { get; set; }
  
}