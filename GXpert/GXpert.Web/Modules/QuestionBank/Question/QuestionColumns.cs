using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.QuestionBank.Columns;

[ColumnsScript("QuestionBank.Question")]
[BasedOnRow(typeof(QuestionRow), CheckNames = true)]
public class QuestionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public long Id { get; set; }
    [EditLink]
    public string QuestionText { get; set; }
    public string Explaination { get; set; }
    public bool IsSubjective { get; set; }
    [QuickFilter]
    public short EQuestionType { get; set; }
    public short EDifficultyLevel { get; set; }
    public string QuestionCommonDataCommonDataTitle { get; set; }
    public float QuestionCommonDataSortOrder { get; set; }
    public string ClassTitle { get; set; }
    public string SubjectTitle { get; set; }
    public string TopicTitle { get; set; }
    public string BloomsIndexCoginitiveSkill { get; set; }
    public float BloomsWeightage { get; set; }
    public List<QuestionOptionRow> QuestionOptions { get; set; }
    [DisplayName("Date"), QuickFilter, FilterOnly]
    public DateTime InsertDate { get; set; }
}