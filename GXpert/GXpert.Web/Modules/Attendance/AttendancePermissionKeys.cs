using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Attendance
{
    [NestedPermissionKeys]
    [DisplayName("Attendance")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Attendance:General";

        [DisplayName("Attendance Management")]
        public class AttendanceManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Attendance:AttendanceManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Attendance:AttendanceManagement:Modify";
            public const string View = "Attendance:AttendanceManagement:View";
        }
        
        
    }
}