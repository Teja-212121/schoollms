using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Masters
{
    [NestedPermissionKeys]
    [DisplayName("Masters")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Masters:General";

        [DisplayName("Masters Management")]
        public class MastersManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Masters:MastersManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Masters:MastersManagement:Modify";
            public const string View = "Masters:MastersManagement:View";
        }
        
        
    }
}