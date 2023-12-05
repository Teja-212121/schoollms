namespace GXpert.Administration;

public class RolePermissionUpdateRequest : ServiceRequest
{
    public int? RoleID { get; set; }
    public string Module { get; set; }
    public string Submodule { get; set; }
    public List<string> Permissions { get; set; }
}