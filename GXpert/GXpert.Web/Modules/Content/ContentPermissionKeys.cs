using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Content
{
    [NestedPermissionKeys]
    [DisplayName("Content")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Content:General";

        [DisplayName("Content Management")]
        public class ContentManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Content:ContentManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Content:ContentManagement:Modify";
            public const string View = "Content:ContentManagement:View";
        }
        
        
    }
}