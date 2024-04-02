using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Users
{
    [NestedPermissionKeys]
    [DisplayName("Users")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Users:General";

        [DisplayName("Users Management")]
        public class UsersManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Users:UsersManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Users:UsersManagement:Modify";
            public const string View = "Users:UsersManagement:View";
        }
        
        
    }
}