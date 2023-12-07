using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Web.Enums
{
    public enum EExamAttemptStatus
    {
        [Description("Assigned")]
        Assigned = 1,
        [Description("Started")]
        Started = 2,
        [Description("Uploading")]
        Uploading = 3,
        [Description("Upload Complete")]
        UploadComplete = 4,
        [Description("TeacherAssigned")]
        TeacherAssigned = 5,
        [Description("TeacherAccepted")]
        TeacherAccepted = 6,
        [Description("TeacherRejected")]
        TeacherRejected = 7,
        [Description("Ended")]
        Ended = 8,
       [Description("Recheck")]
        Recheck = 9
    }
}