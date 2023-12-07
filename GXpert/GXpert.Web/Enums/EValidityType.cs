
using System.ComponentModel;

namespace GXpert.Web.Enums
{
    public enum EValidityType
    {
        [Description("Unlimited")]
        Unlimited = 1,
        [Description("Fixed Date")]
        FixedDate = 2,
        [Description("Validity In Days")]
        ValidityInDays = 3
    }
}