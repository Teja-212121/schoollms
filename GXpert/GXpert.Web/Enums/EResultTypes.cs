using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Web.Enums
{
    [EnumKey("Workspace.EResultTypes")]
    public enum EResultTypes
    {
        [Description("AFTER EXAM ON SERVER")]
        AFTER_EXAM_ON_SERVER,
        [Description("AFTER EXAM ON CLIENT")]
        AFTER_EXAM_ON_CLIENT,
        [Description("AFTER QUESTION ON CLIENT")]
        AFTER_QUESTION_ON_CLIENT
    }
}