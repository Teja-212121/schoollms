using Serenity.ComponentModel;
using System;

namespace GXpert.Attendance.Forms;

[FormScript("Attendance.AssignmentAttempt")]
[BasedOnRow(typeof(AssignmentAttemptRow), CheckNames = true)]
public class AssignmentAttemptForm
{
    [HalfWidth]
    public int AssignmentId { get; set; }
    [HalfWidth]
    public int StudentId { get; set; }
    public string FileUploaded { get; set; }
    [HalfWidth]
    public short EStatus { get; set; }
    [HalfWidth]
    public int TeacherId { get; set; }
    [HalfWidth]
    public int PlayListId { get; set; }
    [HalfWidth]
    public int ActivationId { get; set; }
}