using Serenity.ComponentModel;

namespace GXpert.Web.Enums
{
    [EnumKey("Workspace.EQuestionTypes")]
    public enum EQuestionType
    {
        SINGLE_RIGHT_ANSWER,
        MULTIPLE_RIGHT_ANSWER,
        TRUE_OR_FALSE,
        NUMERICAL,
        FILL_IN_THE_BLANK,
        MATCHING,
        ORDER_OR_SEQUENCING
    }
}
