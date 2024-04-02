using Serenity.ComponentModel;
using System.ComponentModel;

namespace GXpert.Playlist
{
    [NestedPermissionKeys]
    [DisplayName("Playlist")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "Playlist:General";

        [DisplayName("Playlist Management")]
        public class PlaylistManagement
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "Playlist:PlaylistManagement:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "Playlist:PlaylistManagement:Modify";
            public const string View = "Playlist:PlaylistManagement:View";
        }
        
        
    }
}