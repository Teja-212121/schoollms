using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Activation
{
    [NestedPermissionKeys]
    [DisplayName("Activation")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Activation:General";

        [DisplayName("Activation Management")]
        public class ActivationManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Activation:ActivationManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Activation:ActivationManagement:Modify";
            public const string View = "Activation:ActivationManagement:View";
        }
        
        
    }
}