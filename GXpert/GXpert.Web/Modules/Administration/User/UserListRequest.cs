using Microsoft.AspNetCore.DataProtection;

namespace GXpert.Administration;
public class UserListRequest : ListRequest
{
    [System.Text.Json.Serialization.JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    internal IDataProtector DataProtector;
    [System.Text.Json.Serialization.JsonIgnore]
    [Newtonsoft.Json.JsonIgnore]
    internal byte[] ClientHash;
}
