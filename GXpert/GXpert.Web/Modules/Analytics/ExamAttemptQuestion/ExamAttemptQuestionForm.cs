using Serenity.ComponentModel;
using System;

namespace GXpert.Analytics.Forms;

[FormScript("Analytics.ExamAttemptQuestion")]
[BasedOnRow(typeof(ExamAttemptQuestionRow), CheckNames = true)]
public class ExamAttemptQuestionForm
{
    [HalfWidth]
    public int ExamAttemptId { get; set; }
    [HalfWidth]
    public int ExamQuestionId { get; set; }
    [HalfWidth]
    public string OptionSelected { get; set; }
    [HalfWidth]
    public int MarksObtained { get; set; }
    [HalfWidth]
    public short Attemptstatus { get; set; }
    [HalfWidth]
    public int OutOfmarks { get; set; }
    [HalfWidth]
    public string Result { get; set; }
}