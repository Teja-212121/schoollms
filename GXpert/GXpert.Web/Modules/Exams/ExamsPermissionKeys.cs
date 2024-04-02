using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Exams
{
    [NestedPermissionKeys]
    [DisplayName("Exams")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Exams:General";

        [DisplayName("Exams Management")]
        public class ExamsManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Exams:ExamsManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Exams:ExamsManagement:Modify";
            public const string View = "Exams:ExamsManagement:View";
        }
        
        
    }
}