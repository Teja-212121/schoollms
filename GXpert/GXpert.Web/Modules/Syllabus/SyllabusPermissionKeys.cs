using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Syllabus
{
    [NestedPermissionKeys]
    [DisplayName("Syllabus")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Syllabus:General";

        [DisplayName("Syllabus Management")]
        public class SyllabusManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Syllabus:SyllabusManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Syllabus:SyllabusManagement:Modify";
            public const string View = "Syllabus:SyllabusManagement:View";
        }
        
        
    }
}