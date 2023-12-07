using Serenity.ComponentModel;
using System;

namespace GXpert.Analytics.Forms;

[FormScript("Analytics.ExamAttempt")]
[BasedOnRow(typeof(ExamAttemptRow), CheckNames = true)]
public class ExamAttemptForm
{
    [HalfWidth]
    public int ExamId { get; set; }
    [HalfWidth]
    public int StudentId { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
    [HalfWidth]
    public short EStatus { get; set; }
    [HalfWidth]
    public int TimeSpent { get; set; }
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public string StudentAnswerSheetUpload { get; set; }
    [HalfWidth]
    public string TeacherCheckedPaperUpload { get; set; }
    [HalfWidth]
    public int ActivationId { get; set; }
}