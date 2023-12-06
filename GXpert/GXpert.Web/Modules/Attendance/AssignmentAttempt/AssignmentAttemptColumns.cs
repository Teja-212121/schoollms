using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace GXpert.Attendance.Columns;

[ColumnsScript("Attendance.AssignmentAttempt")]
[BasedOnRow(typeof(AssignmentAttemptRow), CheckNames = true)]
public class AssignmentAttemptColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int Id { get; set; }
    public string AssignmentTitle { get; set; }
    public string StudentPrn { get; set; }
    [EditLink]
    public string FileUploaded { get; set; }
    public string EStatus { get; set; }
    public string TeacherPrn { get; set; }
    public string PlayListTitle { get; set; }
    public string ActivationDeviceId { get; set; }
}