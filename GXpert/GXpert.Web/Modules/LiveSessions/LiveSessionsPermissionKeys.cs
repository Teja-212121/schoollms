using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.LiveSessions
{
    [NestedPermissionKeys]
    [DisplayName("LiveSessions")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "LiveSessions:General";

        [DisplayName("LiveSessions Management")]
        public class LiveSessionsManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "LiveSessions:LiveSessionsManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "LiveSessions:LiveSessionsManagement:Modify";
            public const string View = "LiveSessions:LiveSessionsManagement:View";
        }
        
        
    }
}