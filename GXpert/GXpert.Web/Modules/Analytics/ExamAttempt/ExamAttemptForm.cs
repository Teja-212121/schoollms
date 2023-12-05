using Serenity.ComponentModel;
using System;

namespace GXpert.Analytics.Forms;

[FormScript("Analytics.ExamAttempt")]
[BasedOnRow(typeof(ExamAttemptRow), CheckNames = true)]
public class ExamAttemptForm
{
    public int ExamId { get; set; }
    public int StudentId { get; set; }
    public int TeacherId { get; set; }
    public short EStatus { get; set; }
    public int TimeSpent { get; set; }
    public int PlayListId { get; set; }
    public string StudentAnswerSheetUpload { get; set; }
    public string TeacherCheckedPaperUpload { get; set; }
    public int ActivationId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}