using Serenity.ComponentModel;
using System;

namespace GXpert.Analytics.Forms;

[FormScript("Analytics.ExamAttemptQuestion")]
[BasedOnRow(typeof(ExamAttemptQuestionRow), CheckNames = true)]
public class ExamAttemptQuestionForm
{
    public int ExamAttemptId { get; set; }
    public int ExamQuestionId { get; set; }
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