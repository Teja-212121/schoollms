using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.AssignmentAttempt")]
[BasedOnRow(typeof(AssignmentAttemptRow), CheckNames = true)]
public class AssignmentAttemptForm
{
    public int AssignmentId { get; set; }
    public int StudentId { get; set; }
    public string FileUploaded { get; set; }
    public string EStatus { get; set; }
    public int TeacherId { get; set; }
    public int PlayListId { get; set; }
    public int ActivationId { get; set; }
    public DateTime InsertDate { get; set; }
    public int InsertUserId { get; set; }
    public DateTime UpdateDate { get; set; }
    public int UpdateUserId { get; set; }
    public bool IsActive { get; set; }
}