using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Institute
{
    [NestedPermissionKeys]
    [DisplayName("Institute")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Institute:General";

        [DisplayName("Institute Management")]
        public class InstituteManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Institute:InstituteManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Institute:InstituteManagement:Modify";
            public const string View = "Institute:InstituteManagement:View";
        }
        
        
    }
}