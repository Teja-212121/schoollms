using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Skills
{
    [NestedPermissionKeys]
    [DisplayName("Skills")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Skills:General";

        [DisplayName("Skills Management")]
        public class SkillsManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Skills:SkillsManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Skills:SkillsManagement:Modify";
            public const string View = "Skills:SkillsManagement:View";
        }
        
        
    }
}