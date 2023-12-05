using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Analytics.Columns;

[ColumnsScript("Analytics.ExamAttemptQuestion")]
[BasedOnRow(typeof(ExamAttemptQuestionRow), CheckNames = true)]
public class ExamAttemptQuestionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ExamAttemptStudentAnswerSheetUpload { get; set; }
    public string ExamQuestionRightAnswer { get; set; }
    [EditLink]
    public string OptionSelected { get; set; }
    public int MarksObtained { get; set; }
    public short Attemptstatus { get; set; }
    public int OutOfmarks { get; set; }
    public string Result { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}