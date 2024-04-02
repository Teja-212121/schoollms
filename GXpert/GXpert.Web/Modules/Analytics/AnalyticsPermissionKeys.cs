using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Analytics
{
    [NestedPermissionKeys]
    [DisplayName("Analytics")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Analytics:General";

        [DisplayName("Analytics Management")]
        public class AnalyticsManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Analytics:AnalyticsManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Analytics:AnalyticsManagement:Modify";
            public const string View = "Analytics:AnalyticsManagement:View";
        }
        
        
    }
}