using System.ComponentModel;

namespace GXpert.Web.Enums
{
    public enum EContentType
    {
        [Description("Video")]
        Video = 1,
        [Description("Audio")]
        Audio = 2,
        [Description(" Pdf")]
        Pdf = 3,
        [Description("Exam")]
        Exam = 4,
        [Description("Html")]
        Html = 5,
        [Description("Meeting")]
        Meeting = 6


    }
}