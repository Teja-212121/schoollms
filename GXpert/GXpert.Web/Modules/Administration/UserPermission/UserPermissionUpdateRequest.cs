namespace GXpert.Administration;

public class UserPermissionUpdateRequest : ServiceRequest
{
    public int? UserID { get; set; }
    public string Module { get; set; }
    public string Submodule { get; set; }
    public List<UserPermissionRow> Permissions { get; set; }
}