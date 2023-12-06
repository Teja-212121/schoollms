using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Analytics.Columns;

[ColumnsScript("Analytics.ExamAttempt")]
[BasedOnRow(typeof(ExamAttemptRow), CheckNames = true)]
public class ExamAttemptColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string ExamTitle { get; set; }
    public string StudentPrn { get; set; }
    public string TeacherPrn { get; set; }
    public short EStatus { get; set; }
    public int TimeSpent { get; set; }
    public string PlayListTitle { get; set; }
    [EditLink]
    public string StudentAnswerSheetUpload { get; set; }
    public string TeacherCheckedPaperUpload { get; set; }
    public string ActivationDeviceId { get; set; }
}