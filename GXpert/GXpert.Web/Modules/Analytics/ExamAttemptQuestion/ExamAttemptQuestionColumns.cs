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
    [QuickFilter]
    public short Attemptstatus { get; set; }
    public int OutOfmarks { get; set; }
    public string Result { get; set; }
}